
CREATE DATABASE ProjetoMVC;
GO

USE ProjetoMVC;
GO

-- USUÁRIOS
CREATE TABLE Usuario
(
    usuario_id INT IDENTITY PRIMARY KEY,
    nome VARCHAR(250) NOT NULL,
    email VARCHAR(250) NOT NULL,
    senha VARCHAR(250) NOT NULL,
    cpf VARCHAR(14) NOT NULL,
    telefone VARCHAR(20) NOT NULL,
    cargo VARCHAR(50) NOT NULL
);

-- CLIENTES
CREATE TABLE Cliente
(
    cliente_id INT IDENTITY PRIMARY KEY,
    nome VARCHAR(250) NOT NULL,
    cpf VARCHAR(14) NOT NULL,
    qt_veiculos INT NOT NULL DEFAULT 0,
    telefone VARCHAR(20) NOT NULL,
    email VARCHAR(250) NULL,
    cep INT NOT NULL,
    endereco VARCHAR(250) NOT NULL,
    cidade VARCHAR(100) NOT NULL
);

-- VEÍCULOS
CREATE TABLE Veiculo
(
    veiculo_id INT IDENTITY PRIMARY KEY,
    cliente_id INT NOT NULL,
    placa VARCHAR(10) NOT NULL,
    marca VARCHAR(100) NOT NULL,
    modelo VARCHAR(100) NOT NULL,
    ano INT NOT NULL,
    cor VARCHAR(50),
    motor VARCHAR(50),
    combustivel VARCHAR(30),

    FOREIGN KEY (cliente_id)
    REFERENCES Cliente(cliente_id)
);

-- ORDENS DE SERVIÇO
CREATE TABLE OrdemServico
(
    ordem_servico_id INT IDENTITY PRIMARY KEY,
    cliente_id INT NOT NULL,
    veiculo_id INT NOT NULL,
    data_abertura DATETIME NOT NULL,
    data_previsao DATETIME NULL,
    data_fechamento DATETIME NULL,
    status VARCHAR(50) NOT NULL,
    descricao_problema VARCHAR(500) NOT NULL,
    diagnostico VARCHAR(500) NOT NULL,
    observacoes VARCHAR(500) NOT NULL,
    valor_mao_obra DECIMAL(10,2) NOT NULL,
    valor_total DECIMAL(10,2) NOT NULL,

    FOREIGN KEY (cliente_id)
    REFERENCES Cliente(cliente_id),

    FOREIGN KEY (veiculo_id)
    REFERENCES Veiculo(veiculo_id)
);

-- ITENS DA ORDEM DE SERVIÇO
CREATE TABLE OrdemServicoItem
(
    item_id INT IDENTITY PRIMARY KEY,
    ordem_servico_id INT NOT NULL,
    tipo VARCHAR(50) NOT NULL,
    descricao VARCHAR(250) NOT NULL,
    quantidade DECIMAL(10,2) NOT NULL,
    valor_unitario DECIMAL(10,2) NOT NULL,
    subtotal DECIMAL(10,2) NOT NULL,

    FOREIGN KEY (ordem_servico_id)
    REFERENCES OrdemServico(ordem_servico_id)
);

-- HISTÓRICO DA ORDEM DE SERVIÇO
CREATE TABLE OrdemServicoHistorico
(
    historico_id INT IDENTITY PRIMARY KEY,
    ordem_servico_id INT NOT NULL,
    status_anterior VARCHAR(50) NOT NULL,
    status_novo VARCHAR(50) NOT NULL,
    data_alteracao DATETIME NOT NULL DEFAULT GETDATE(),

    FOREIGN KEY (ordem_servico_id)
    REFERENCES OrdemServico(ordem_servico_id)
    ON DELETE CASCADE
);

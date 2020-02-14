
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 02/13/2020 19:26:37
-- Generated from EDMX file: C:\Users\WIN 10\Documents\Proyecto-Consultorio-Medico(oficial)\Proyecto_Consultorio_Medico\Modelo\Model1.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [Proyecto centro medico (oficial)];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_ConsultaMedica_HistorialConsultas]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ConsultaMedica] DROP CONSTRAINT [FK_ConsultaMedica_HistorialConsultas];
GO
IF OBJECT_ID(N'[dbo].[FK_ConsultaMedica_Medicos]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ConsultaMedica] DROP CONSTRAINT [FK_ConsultaMedica_Medicos];
GO
IF OBJECT_ID(N'[dbo].[FK_Consultorios_Especialidades]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Consultorios] DROP CONSTRAINT [FK_Consultorios_Especialidades];
GO
IF OBJECT_ID(N'[dbo].[FK_HistorialConsultas_Pacientes]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[HistorialConsultas] DROP CONSTRAINT [FK_HistorialConsultas_Pacientes];
GO
IF OBJECT_ID(N'[dbo].[FK_MedicoConsultorio_Consultorios]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[MedicoConsultorio] DROP CONSTRAINT [FK_MedicoConsultorio_Consultorios];
GO
IF OBJECT_ID(N'[dbo].[FK_MedicoConsultorio_Medicos]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[MedicoConsultorio] DROP CONSTRAINT [FK_MedicoConsultorio_Medicos];
GO
IF OBJECT_ID(N'[dbo].[FK_MedicoEspecialidad_Especialidades]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[MedicoEspecialidad] DROP CONSTRAINT [FK_MedicoEspecialidad_Especialidades];
GO
IF OBJECT_ID(N'[dbo].[FK_MedicoEspecialidad_Medicos]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[MedicoEspecialidad] DROP CONSTRAINT [FK_MedicoEspecialidad_Medicos];
GO
IF OBJECT_ID(N'[dbo].[FK_Turnos_Consultorios]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Turnos] DROP CONSTRAINT [FK_Turnos_Consultorios];
GO
IF OBJECT_ID(N'[dbo].[FK_Turnos_Pacientes]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Turnos] DROP CONSTRAINT [FK_Turnos_Pacientes];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[ConsultaMedica]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ConsultaMedica];
GO
IF OBJECT_ID(N'[dbo].[Consultorios]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Consultorios];
GO
IF OBJECT_ID(N'[dbo].[Especialidades]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Especialidades];
GO
IF OBJECT_ID(N'[dbo].[HistorialConsultas]', 'U') IS NOT NULL
    DROP TABLE [dbo].[HistorialConsultas];
GO
IF OBJECT_ID(N'[dbo].[MedicoConsultorio]', 'U') IS NOT NULL
    DROP TABLE [dbo].[MedicoConsultorio];
GO
IF OBJECT_ID(N'[dbo].[MedicoEspecialidad]', 'U') IS NOT NULL
    DROP TABLE [dbo].[MedicoEspecialidad];
GO
IF OBJECT_ID(N'[dbo].[Medicos]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Medicos];
GO
IF OBJECT_ID(N'[dbo].[Pacientes]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Pacientes];
GO
IF OBJECT_ID(N'[dbo].[sysdiagrams]', 'U') IS NOT NULL
    DROP TABLE [dbo].[sysdiagrams];
GO
IF OBJECT_ID(N'[dbo].[Turnos]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Turnos];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'ConsultaMedica'
CREATE TABLE [dbo].[ConsultaMedica] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Id_Medico] int  NOT NULL,
    [Id_Historico] int  NOT NULL,
    [Fecha] datetime  NULL,
    [Estado] varchar(20)  NULL,
    [Estudios] varchar(50)  NULL,
    [FechaProxConsulta] datetime  NULL,
    [Sintomas] varchar(100)  NULL,
    [Diagnostico] varchar(100)  NULL,
    [MedicacionSugerida] varchar(100)  NULL,
    [Observaciones] varchar(100)  NULL,
    [Notas] varchar(max)  NULL,
    [EstudiosSolicitados] varchar(100)  NULL,
    [EstudiosResibidos] varchar(100)  NULL,
    [ResultadosEstudiosResibidos] varchar(100)  NULL
);
GO

-- Creating table 'Consultorios'
CREATE TABLE [dbo].[Consultorios] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Id_Especialidad] int  NOT NULL,
    [Nombre] varchar(50)  NOT NULL,
    [HayTurnos] bit  NULL
);
GO

-- Creating table 'Especialidades'
CREATE TABLE [dbo].[Especialidades] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Nombre] varchar(50)  NULL
);
GO

-- Creating table 'HistorialConsultas'
CREATE TABLE [dbo].[HistorialConsultas] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Id_Paciente] int  NOT NULL,
    [AntecedentesFliares] varchar(100)  NULL
);
GO

-- Creating table 'MedicoConsultorio'
CREATE TABLE [dbo].[MedicoConsultorio] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Id_Medico] int  NOT NULL,
    [Id_Consultorio] int  NOT NULL,
    [H_Entrada] time  NOT NULL,
    [H_Salida] time  NOT NULL,
    [Lunes] bit  NULL,
    [Martes] bit  NULL,
    [Miercoles] bit  NULL,
    [Jueves] bit  NULL,
    [Viernes] bit  NULL,
    [Sabado] bit  NULL,
    [Domingo] bit  NULL
);
GO

-- Creating table 'MedicoEspecialidad'
CREATE TABLE [dbo].[MedicoEspecialidad] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Id_Medico] int  NOT NULL,
    [Id_Especialidad] int  NOT NULL
);
GO

-- Creating table 'Medicos'
CREATE TABLE [dbo].[Medicos] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Nombre] varchar(50)  NOT NULL,
    [Apellido] varchar(50)  NOT NULL,
    [DNI] varchar(10)  NOT NULL,
    [Direccion] varchar(50)  NULL,
    [CantidadTurnos] int  NULL,
    [FechaNac] datetime  NULL,
    [Matricula] varchar(50)  NOT NULL,
    [Telefono] varchar(15)  NULL,
    [ContactoAux] varchar(15)  NULL,
    [Foto] varchar(50)  NULL,
    [Curricula] varchar(max)  NULL
);
GO

-- Creating table 'Pacientes'
CREATE TABLE [dbo].[Pacientes] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Nombre] varchar(50)  NOT NULL,
    [Apellido] varchar(50)  NOT NULL,
    [FechaNac] datetime  NULL,
    [FechaIngreso] datetime  NOT NULL,
    [DNI] varchar(9)  NOT NULL,
    [ObraSocial] varchar(50)  NULL,
    [Telefono] varchar(10)  NOT NULL,
    [Direccion] varchar(100)  NULL,
    [Foto] varchar(50)  NULL,
    [UltimaVisita] datetime  NULL,
    [Detalles] varchar(150)  NULL
);
GO

-- Creating table 'sysdiagrams'
CREATE TABLE [dbo].[sysdiagrams] (
    [name] nvarchar(128)  NOT NULL,
    [principal_id] int  NOT NULL,
    [diagram_id] int IDENTITY(1,1) NOT NULL,
    [version] int  NULL,
    [definition] varbinary(max)  NULL
);
GO

-- Creating table 'Turnos'
CREATE TABLE [dbo].[Turnos] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Id_Paciente] int  NOT NULL,
    [Id_Consultorio] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'ConsultaMedica'
ALTER TABLE [dbo].[ConsultaMedica]
ADD CONSTRAINT [PK_ConsultaMedica]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Consultorios'
ALTER TABLE [dbo].[Consultorios]
ADD CONSTRAINT [PK_Consultorios]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Especialidades'
ALTER TABLE [dbo].[Especialidades]
ADD CONSTRAINT [PK_Especialidades]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'HistorialConsultas'
ALTER TABLE [dbo].[HistorialConsultas]
ADD CONSTRAINT [PK_HistorialConsultas]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'MedicoConsultorio'
ALTER TABLE [dbo].[MedicoConsultorio]
ADD CONSTRAINT [PK_MedicoConsultorio]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'MedicoEspecialidad'
ALTER TABLE [dbo].[MedicoEspecialidad]
ADD CONSTRAINT [PK_MedicoEspecialidad]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Medicos'
ALTER TABLE [dbo].[Medicos]
ADD CONSTRAINT [PK_Medicos]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Pacientes'
ALTER TABLE [dbo].[Pacientes]
ADD CONSTRAINT [PK_Pacientes]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [diagram_id] in table 'sysdiagrams'
ALTER TABLE [dbo].[sysdiagrams]
ADD CONSTRAINT [PK_sysdiagrams]
    PRIMARY KEY CLUSTERED ([diagram_id] ASC);
GO

-- Creating primary key on [Id] in table 'Turnos'
ALTER TABLE [dbo].[Turnos]
ADD CONSTRAINT [PK_Turnos]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [Id_Historico] in table 'ConsultaMedica'
ALTER TABLE [dbo].[ConsultaMedica]
ADD CONSTRAINT [FK_ConsultaMedica_HistorialConsultas]
    FOREIGN KEY ([Id_Historico])
    REFERENCES [dbo].[HistorialConsultas]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ConsultaMedica_HistorialConsultas'
CREATE INDEX [IX_FK_ConsultaMedica_HistorialConsultas]
ON [dbo].[ConsultaMedica]
    ([Id_Historico]);
GO

-- Creating foreign key on [Id_Medico] in table 'ConsultaMedica'
ALTER TABLE [dbo].[ConsultaMedica]
ADD CONSTRAINT [FK_ConsultaMedica_Medicos]
    FOREIGN KEY ([Id_Medico])
    REFERENCES [dbo].[Medicos]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ConsultaMedica_Medicos'
CREATE INDEX [IX_FK_ConsultaMedica_Medicos]
ON [dbo].[ConsultaMedica]
    ([Id_Medico]);
GO

-- Creating foreign key on [Id_Especialidad] in table 'Consultorios'
ALTER TABLE [dbo].[Consultorios]
ADD CONSTRAINT [FK_Consultorios_Especialidades]
    FOREIGN KEY ([Id_Especialidad])
    REFERENCES [dbo].[Especialidades]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Consultorios_Especialidades'
CREATE INDEX [IX_FK_Consultorios_Especialidades]
ON [dbo].[Consultorios]
    ([Id_Especialidad]);
GO

-- Creating foreign key on [Id_Consultorio] in table 'MedicoConsultorio'
ALTER TABLE [dbo].[MedicoConsultorio]
ADD CONSTRAINT [FK_MedicoConsultorio_Consultorios]
    FOREIGN KEY ([Id_Consultorio])
    REFERENCES [dbo].[Consultorios]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_MedicoConsultorio_Consultorios'
CREATE INDEX [IX_FK_MedicoConsultorio_Consultorios]
ON [dbo].[MedicoConsultorio]
    ([Id_Consultorio]);
GO

-- Creating foreign key on [Id_Consultorio] in table 'Turnos'
ALTER TABLE [dbo].[Turnos]
ADD CONSTRAINT [FK_Turnos_Consultorios]
    FOREIGN KEY ([Id_Consultorio])
    REFERENCES [dbo].[Consultorios]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Turnos_Consultorios'
CREATE INDEX [IX_FK_Turnos_Consultorios]
ON [dbo].[Turnos]
    ([Id_Consultorio]);
GO

-- Creating foreign key on [Id_Especialidad] in table 'MedicoEspecialidad'
ALTER TABLE [dbo].[MedicoEspecialidad]
ADD CONSTRAINT [FK_MedicoEspecialidad_Especialidades]
    FOREIGN KEY ([Id_Especialidad])
    REFERENCES [dbo].[Especialidades]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_MedicoEspecialidad_Especialidades'
CREATE INDEX [IX_FK_MedicoEspecialidad_Especialidades]
ON [dbo].[MedicoEspecialidad]
    ([Id_Especialidad]);
GO

-- Creating foreign key on [Id_Paciente] in table 'HistorialConsultas'
ALTER TABLE [dbo].[HistorialConsultas]
ADD CONSTRAINT [FK_HistorialConsultas_Pacientes]
    FOREIGN KEY ([Id_Paciente])
    REFERENCES [dbo].[Pacientes]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_HistorialConsultas_Pacientes'
CREATE INDEX [IX_FK_HistorialConsultas_Pacientes]
ON [dbo].[HistorialConsultas]
    ([Id_Paciente]);
GO

-- Creating foreign key on [Id_Medico] in table 'MedicoConsultorio'
ALTER TABLE [dbo].[MedicoConsultorio]
ADD CONSTRAINT [FK_MedicoConsultorio_Medicos]
    FOREIGN KEY ([Id_Medico])
    REFERENCES [dbo].[Medicos]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_MedicoConsultorio_Medicos'
CREATE INDEX [IX_FK_MedicoConsultorio_Medicos]
ON [dbo].[MedicoConsultorio]
    ([Id_Medico]);
GO

-- Creating foreign key on [Id_Medico] in table 'MedicoEspecialidad'
ALTER TABLE [dbo].[MedicoEspecialidad]
ADD CONSTRAINT [FK_MedicoEspecialidad_Medicos]
    FOREIGN KEY ([Id_Medico])
    REFERENCES [dbo].[Medicos]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_MedicoEspecialidad_Medicos'
CREATE INDEX [IX_FK_MedicoEspecialidad_Medicos]
ON [dbo].[MedicoEspecialidad]
    ([Id_Medico]);
GO

-- Creating foreign key on [Id_Paciente] in table 'Turnos'
ALTER TABLE [dbo].[Turnos]
ADD CONSTRAINT [FK_Turnos_Pacientes]
    FOREIGN KEY ([Id_Paciente])
    REFERENCES [dbo].[Pacientes]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Turnos_Pacientes'
CREATE INDEX [IX_FK_Turnos_Pacientes]
ON [dbo].[Turnos]
    ([Id_Paciente]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------
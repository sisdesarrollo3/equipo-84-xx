---------------------------------------------
-- Schema proyectos_g27xx
-- -----------------------------------------------------

-- -----------------------------------------------------
-- Table rol
-- -----------------------------------------------------
CREATE TABLE  rol (
  rol_id [int] IDENTITY(1,1) NOT NULL,
  rol_nombre VARCHAR(50) NULL,
  rol_descripcion TEXT NULL,
  PRIMARY KEY (rol_id))
;


-- -----------------------------------------------------
-- Table estado_proyecto
-- -----------------------------------------------------
CREATE TABLE  estado_proyecto (
  estpro_id [int] IDENTITY(1,1) NOT NULL,
  estpro_nombre VARCHAR(50) NOT NULL,
  PRIMARY KEY (estpro_id))
;


-- -----------------------------------------------------
-- Table estado_tarea
-- -----------------------------------------------------
CREATE TABLE  estado_tarea (
  esttar_id [int] IDENTITY(1,1) NOT NULL,
  esttar_nombre VARCHAR(50) NOT NULL,
  PRIMARY KEY (esttar_id))
;


-- -----------------------------------------------------
-- Table formador
-- -----------------------------------------------------
CREATE TABLE  formador (
  for_identificacion VARCHAR(20) NOT NULL,
  for_nombre VARCHAR(100) NOT NULL,
  for_mail VARCHAR(250) NOT NULL,
  for_movil VARCHAR(50) NULL,
  PRIMARY KEY (for_identificacion))
;


-- -----------------------------------------------------
-- Table tutor
-- -----------------------------------------------------
CREATE TABLE  tutor (
  tut_identificacion VARCHAR(20) NOT NULL,
  tut_nombre VARCHAR(100) NOT NULL,
  tut_mail VARCHAR(250) NOT NULL,
  tut_movil VARCHAR(50) NULL,
  PRIMARY KEY (tut_identificacion))
;


-- -----------------------------------------------------
-- Table estudiante
-- -----------------------------------------------------
CREATE TABLE  estudiante (
  est_identificacion VARCHAR(20) NOT NULL,
  est_nombre VARCHAR(100) NOT NULL,
  est_mail VARCHAR(250) NOT NULL,
  est_movil VARCHAR(50) NULL,
  PRIMARY KEY (est_identificacion))
;


-- -----------------------------------------------------
-- Table equipo
-- -----------------------------------------------------
CREATE TABLE  equipo (
  equ_id [int] IDENTITY(1,1) NOT NULL,
  equ_codigo VARCHAR(10) NOT NULL,
  equ_nombre VARCHAR(100) NOT NULL,
  equ_whtasapp TEXT NULL,
  equ_meet TEXT NULL,
  equ_nombre_proyecto VARCHAR(100) NULL,
  equ_tema VARCHAR(100) NULL,
  equ_fecha_inico DATE NULL,
  equ_fecha_final DATE NULL,
  equ_novedad TEXT NULL,
  equ_estado_proyecto INT NOT NULL,
  equ_formador VARCHAR(20) NOT NULL,
  equ_tutor VARCHAR(20) NOT NULL,
  PRIMARY KEY (equ_id),
  CONSTRAINT equipo_fk_estado_proyecto
    FOREIGN KEY (equ_estado_proyecto)
    REFERENCES estado_proyecto (estpro_id)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT fk_equipo_formador1
    FOREIGN KEY (equ_formador)
    REFERENCES formador (for_identificacion)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT fk_equipo_tutor1
    FOREIGN KEY (equ_tutor)
    REFERENCES tutor (tut_identificacion)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
;

CREATE INDEX equipo_fk_estado_proyecto_idx ON equipo (equ_estado_proyecto ASC) ;

CREATE INDEX fk_equipo_formador1_idx ON equipo (equ_formador ASC) ;

CREATE INDEX fk_equipo_tutor1_idx ON equipo (equ_tutor ASC) ;


-- -----------------------------------------------------
-- Table equipo_estudiante
-- -----------------------------------------------------
CREATE TABLE  equipo_estudiante (
  equest_estudiante VARCHAR(20) NOT NULL,
  equest_equipo INT ,
  equest_rol INT NOT NULL,
  equest_nota1 FLOAT NULL,
  equest_nota2 FLOAT NULL,
  equest_nota3 FLOAT NULL,
  equest_nota4 FLOAT NULL,
  PRIMARY KEY (equest_estudiante),
  CONSTRAINT fk_equipo_estudiante_estudiante1
    FOREIGN KEY (equest_estudiante)
    REFERENCES estudiante (est_identificacion)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT fk_equipo_estudiante_equipo1
    FOREIGN KEY (equest_equipo)
    REFERENCES equipo (equ_id)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT fk_equipo_estudiante_rol1
    FOREIGN KEY (equest_rol)
    REFERENCES rol (rol_id)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
;

CREATE INDEX fk_equipo_estudiante_estudiante1_idx ON equipo_estudiante (equest_estudiante ASC) ;

CREATE INDEX fk_equipo_estudiante_equipo1_idx ON equipo_estudiante (equest_equipo ASC) ;

CREATE INDEX fk_equipo_estudiante_rol1_idx ON equipo_estudiante (equest_rol ASC) ;


-- -----------------------------------------------------
-- Table sprint
-- -----------------------------------------------------
CREATE TABLE  sprint (
  spr_id [int] IDENTITY(1,1) NOT NULL,
  spr_codigo VARCHAR(20) NOT NULL,
  spr_nombre VARCHAR(100) NOT NULL,
  spr_fecha_inicio DATE NOT NULL,
  spr_fecha_final DATE NOT NULL,
  spr_puntos INT NOT NULL,
  PRIMARY KEY (spr_id))
;


-- -----------------------------------------------------
-- Table tarea
-- -----------------------------------------------------
CREATE TABLE  tarea (
  tar_id [int] IDENTITY(1,1) NOT NULL,
  tar_codigo VARCHAR(20) NOT NULL,
  tar_nombre VARCHAR(100) NOT NULL,
  tar_puntos INT NOT NULL,
  tar_estudiante VARCHAR(20) NOT NULL,
  tar_novedad TEXT NULL,
  tar_estado_tarea INT NOT NULL,
  tar_sprint INT NOT NULL,
  PRIMARY KEY (tar_id),
  CONSTRAINT fk_tarea_estado_tarea1
    FOREIGN KEY (tar_estado_tarea)
    REFERENCES estado_tarea (esttar_id)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT fk_tarea_sprint1
    FOREIGN KEY (tar_sprint)
    REFERENCES sprint (spr_id)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT fk_tarea_equipo_estudiante1
    FOREIGN KEY (tar_estudiante)
    REFERENCES equipo_estudiante (equest_estudiante)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
;

CREATE INDEX fk_tarea_estado_tarea1_idx ON tarea (tar_estado_tarea ASC) ;

CREATE INDEX fk_tarea_sprint1_idx ON tarea (tar_sprint ASC) ;

CREATE INDEX fk_tarea_equipo_estudiante1_idx ON tarea (tar_estudiante ASC) ;


using Colombia_Api.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colombia_Api.Domain.Seeders
{
    public static class ModelBuilderExtension
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            var _cratedBy = "YouTube"; 
            var _cratedAt = DateTime.UtcNow.AddHours(-5);

            #region Pais
            modelBuilder.Entity<Pais>().HasData(
                new Pais()
                {
                    PaisId = 1,
                    Nombre = "Colombia",
                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Pais()
                {
                    PaisId = 2,
                    Nombre = "Mexico",
                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Pais()
                {
                    PaisId = 3,
                    Nombre = "Uruguay",
                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                }
            );
            #endregion Pais

            #region Departamento
            modelBuilder.Entity<Departamento>().HasData(
                new Departamento
                {
                    DepartamentoId = 5,
                    Nombre = "ANTIOQUIA",
                    PaisId = 1,
                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Departamento
                {
                    DepartamentoId = 8,
                    Nombre = "ATLÁNTICO",
                    PaisId = 1,
                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Departamento
                {
                    DepartamentoId = 11,
                    Nombre = "BOGOTÁ, D.C.",
                    PaisId = 1,
                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Departamento
                {
                    DepartamentoId = 13,
                    Nombre = "BOLÍVAR",
                    PaisId = 1,
                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Departamento
                {
                    DepartamentoId = 15,
                    Nombre = "BOYACÁ",
                    PaisId = 1,
                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Departamento
                {
                    DepartamentoId = 17,
                    Nombre = "CALDAS",
                    PaisId = 1,
                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Departamento
                {
                    DepartamentoId = 18,
                    Nombre = "CAQUETÁ",
                    PaisId = 1,
                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Departamento
                {
                    DepartamentoId = 19,
                    Nombre = "CAUCA",
                    PaisId = 1,
                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Departamento
                {
                    DepartamentoId = 20,
                    Nombre = "CESAR",
                    PaisId = 1,
                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Departamento
                {
                    DepartamentoId = 23,
                    Nombre = "CÓRDOBA",
                    PaisId = 1,
                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Departamento
                {
                    DepartamentoId = 25,
                    Nombre = "CUNDINAMARCA",
                    PaisId = 1,
                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Departamento
                {
                    DepartamentoId = 27,
                    Nombre = "CHOCÓ",
                    PaisId = 1,
                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Departamento
                {
                    DepartamentoId = 41,
                    Nombre = "HUILA",
                    PaisId = 1,
                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Departamento
                {
                    DepartamentoId = 44,
                    Nombre = "LA GUAJIRA",
                    PaisId = 1,
                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Departamento
                {
                    DepartamentoId = 47,
                    Nombre = "MAGDALENA",
                    PaisId = 1,
                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Departamento
                {
                    DepartamentoId = 50,
                    Nombre = "META",
                    PaisId = 1,
                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Departamento
                {
                    DepartamentoId = 52,
                    Nombre = "NARIÑO",
                    PaisId = 1,
                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Departamento
                {
                    DepartamentoId = 54,
                    Nombre = "NORTE DE SANTANDER",
                    PaisId = 1,
                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Departamento
                {
                    DepartamentoId = 63,
                    Nombre = "QUINDIO",
                    PaisId = 1,
                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Departamento
                {
                    DepartamentoId = 66,
                    Nombre = "RISARALDA",
                    PaisId = 1,
                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Departamento
                {
                    DepartamentoId = 68,
                    Nombre = "SANTANDER",
                    PaisId = 1,
                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Departamento
                {
                    DepartamentoId = 70,
                    Nombre = "SUCRE",
                    PaisId = 1,
                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Departamento
                {
                    DepartamentoId = 73,
                    Nombre = "TOLIMA",
                    PaisId = 1,
                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Departamento
                {
                    DepartamentoId = 76,
                    Nombre = "VALLE DEL CAUCA",
                    PaisId = 1,
                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Departamento
                {
                    DepartamentoId = 81,
                    Nombre = "ARAUCA",
                    PaisId = 1,
                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Departamento
                {
                    DepartamentoId = 85,
                    Nombre = "CASANARE",
                    PaisId = 1,
                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Departamento
                {
                    DepartamentoId = 86,
                    Nombre = "PUTUMAYO",
                    PaisId = 1,
                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Departamento
                {
                    DepartamentoId = 88,
                    Nombre = "ARCHIPIÉLAGO DE SAN ANDRÉS, PROVIDENCIA Y SANTA CATALINA",
                    PaisId = 1,
                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Departamento
                {
                    DepartamentoId = 91,
                    Nombre = "AMAZONAS",
                    PaisId = 1,
                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Departamento
                {
                    DepartamentoId = 94,
                    Nombre = "GUAINÍA",
                    PaisId = 1,
                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Departamento
                {
                    DepartamentoId = 95,
                    Nombre = "GUAVIARE",
                    PaisId = 1,
                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Departamento
                {
                    DepartamentoId = 97,
                    Nombre = "VAUPÉS",
                    PaisId = 1,
                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Departamento
                {
                    DepartamentoId = 99,
                    Nombre = "VICHADA",
                    PaisId = 1,
                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                }
            );
            #endregion

            #region Municipio
            modelBuilder.Entity<Municipio>().HasData(
                new Municipio
                {
                    MunicipioId = 1,
                    Nombre = "Abriaquí",
                    DepartamentoId = 5,
                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 2,
                    Nombre = "Acacías",
                    DepartamentoId = 50,
                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 3,
                    Nombre = "Acandí",
                    DepartamentoId = 27,
                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 4,
                    Nombre = "Acevedo",
                    DepartamentoId = 41,
                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 5,
                    Nombre = "Achí",
                    DepartamentoId = 13,
                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 6,
                    Nombre = "Agrado",
                    DepartamentoId = 41,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 7,
                    Nombre = "Agua de Dios",
                    DepartamentoId = 25,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 8,
                    Nombre = "Aguachica",
                    DepartamentoId = 20,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 9,
                    Nombre = "Aguada",
                    DepartamentoId = 68,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 10,
                    Nombre = "Aguadas",
                    DepartamentoId = 17,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 11,
                    Nombre = "Aguazul",
                    DepartamentoId = 85,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 12,
                    Nombre = "Agustín Codazzi",
                    DepartamentoId = 20,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 13,
                    Nombre = "Aipe",
                    DepartamentoId = 41,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 14,
                    Nombre = "Albania",
                    DepartamentoId = 18,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 15,
                    Nombre = "Albania",
                    DepartamentoId = 44,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 16,
                    Nombre = "Albania",
                    DepartamentoId = 68,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 17,
                    Nombre = "Albán",
                    DepartamentoId = 25,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 18,
                    Nombre = "Albán (San José)",
                    DepartamentoId = 52,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 19,
                    Nombre = "Alcalá",
                    DepartamentoId = 76,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 20,
                    Nombre = "Alejandria",
                    DepartamentoId = 5,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 21,
                    Nombre = "Algarrobo",
                    DepartamentoId = 47,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 22,
                    Nombre = "Algeciras",
                    DepartamentoId = 41,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 23,
                    Nombre = "Almaguer",
                    DepartamentoId = 19,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 24,
                    Nombre = "Almeida",
                    DepartamentoId = 15,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 25,
                    Nombre = "Alpujarra",
                    DepartamentoId = 73,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 26,
                    Nombre = "Altamira",
                    DepartamentoId = 41,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 27,
                    Nombre = "Alto Baudó (Pie de Pato)",
                    DepartamentoId = 27,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 28,
                    Nombre = "Altos del Rosario",
                    DepartamentoId = 13,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 29,
                    Nombre = "Alvarado",
                    DepartamentoId = 73,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 30,
                    Nombre = "Amagá",
                    DepartamentoId = 5,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 31,
                    Nombre = "Amalfi",
                    DepartamentoId = 5,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 32,
                    Nombre = "Ambalema",
                    DepartamentoId = 73,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 33,
                    Nombre = "Anapoima",
                    DepartamentoId = 25,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 34,
                    Nombre = "Ancuya",
                    DepartamentoId = 52,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 35,
                    Nombre = "Andalucía",
                    DepartamentoId = 76,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 36,
                    Nombre = "Andes",
                    DepartamentoId = 5,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 37,
                    Nombre = "Angelópolis",
                    DepartamentoId = 5,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 38,
                    Nombre = "Angostura",
                    DepartamentoId = 5,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 39,
                    Nombre = "Anolaima",
                    DepartamentoId = 25,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 40,
                    Nombre = "Anorí",
                    DepartamentoId = 5,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 41,
                    Nombre = "Anserma",
                    DepartamentoId = 17,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 42,
                    Nombre = "Ansermanuevo",
                    DepartamentoId = 76,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 43,
                    Nombre = "Anzoátegui",
                    DepartamentoId = 73,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 44,
                    Nombre = "Anzá",
                    DepartamentoId = 5,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 45,
                    Nombre = "Apartadó",
                    DepartamentoId = 5,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 46,
                    Nombre = "Apulo",
                    DepartamentoId = 25,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 47,
                    Nombre = "Apía",
                    DepartamentoId = 66,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 48,
                    Nombre = "Aquitania",
                    DepartamentoId = 15,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 49,
                    Nombre = "Aracataca",
                    DepartamentoId = 47,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 50,
                    Nombre = "Aranzazu",
                    DepartamentoId = 17,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 51,
                    Nombre = "Aratoca",
                    DepartamentoId = 68,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 52,
                    Nombre = "Arauca",
                    DepartamentoId = 81,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 53,
                    Nombre = "Arauquita",
                    DepartamentoId = 81,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 54,
                    Nombre = "Arbeláez",
                    DepartamentoId = 25,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 55,
                    Nombre = "Arboleda (Berruecos)",
                    DepartamentoId = 52,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 56,
                    Nombre = "Arboledas",
                    DepartamentoId = 54,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 57,
                    Nombre = "Arboletes",
                    DepartamentoId = 5,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 58,
                    Nombre = "Arcabuco",
                    DepartamentoId = 15,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 59,
                    Nombre = "Arenal",
                    DepartamentoId = 13,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 60,
                    Nombre = "Argelia",
                    DepartamentoId = 5,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 61,
                    Nombre = "Argelia",
                    DepartamentoId = 19,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 62,
                    Nombre = "Argelia",
                    DepartamentoId = 76,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 63,
                    Nombre = "Ariguaní (El Difícil)",
                    DepartamentoId = 47,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 64,
                    Nombre = "Arjona",
                    DepartamentoId = 13,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 65,
                    Nombre = "Armenia",
                    DepartamentoId = 5,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 66,
                    Nombre = "Armenia",
                    DepartamentoId = 63,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 67,
                    Nombre = "Armero (Guayabal)",
                    DepartamentoId = 73,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 68,
                    Nombre = "Arroyohondo",
                    DepartamentoId = 13,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 69,
                    Nombre = "Astrea",
                    DepartamentoId = 20,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 70,
                    Nombre = "Ataco",
                    DepartamentoId = 73,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 71,
                    Nombre = "Atrato (Yuto)",
                    DepartamentoId = 27,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 72,
                    Nombre = "Ayapel",
                    DepartamentoId = 23,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 73,
                    Nombre = "Bagadó",
                    DepartamentoId = 27,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 74,
                    Nombre = "Bahía Solano (Mútis)",
                    DepartamentoId = 27,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 75,
                    Nombre = "Bajo Baudó (Pizarro)",
                    DepartamentoId = 27,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 76,
                    Nombre = "Balboa",
                    DepartamentoId = 19,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 77,
                    Nombre = "Balboa",
                    DepartamentoId = 66,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 78,
                    Nombre = "Baranoa",
                    DepartamentoId = 8,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 79,
                    Nombre = "Baraya",
                    DepartamentoId = 41,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 80,
                    Nombre = "Barbacoas",
                    DepartamentoId = 52,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 81,
                    Nombre = "Barbosa",
                    DepartamentoId = 5,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 82,
                    Nombre = "Barbosa",
                    DepartamentoId = 68,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 83,
                    Nombre = "Barichara",
                    DepartamentoId = 68,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 84,
                    Nombre = "Barranca de Upía",
                    DepartamentoId = 50,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 85,
                    Nombre = "Barrancabermeja",
                    DepartamentoId = 68,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 86,
                    Nombre = "Barrancas",
                    DepartamentoId = 44,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 87,
                    Nombre = "Barranco de Loba",
                    DepartamentoId = 13,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 88,
                    Nombre = "Barranquilla",
                    DepartamentoId = 8,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 89,
                    Nombre = "Becerríl",
                    DepartamentoId = 20,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 90,
                    Nombre = "Belalcázar",
                    DepartamentoId = 17,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 91,
                    Nombre = "Bello",
                    DepartamentoId = 5,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 92,
                    Nombre = "Belmira",
                    DepartamentoId = 5,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 93,
                    Nombre = "Beltrán",
                    DepartamentoId = 25,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 94,
                    Nombre = "Belén",
                    DepartamentoId = 15,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 95,
                    Nombre = "Belén",
                    DepartamentoId = 52,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 96,
                    Nombre = "Belén de Bajirá",
                    DepartamentoId = 27,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 97,
                    Nombre = "Belén de Umbría",
                    DepartamentoId = 66,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 98,
                    Nombre = "Belén de los Andaquíes",
                    DepartamentoId = 18,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 99,
                    Nombre = "Berbeo",
                    DepartamentoId = 15,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 100,
                    Nombre = "Betania",
                    DepartamentoId = 5,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 101,
                    Nombre = "Beteitiva",
                    DepartamentoId = 15,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 102,
                    Nombre = "Betulia",
                    DepartamentoId = 5,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 103,
                    Nombre = "Betulia",
                    DepartamentoId = 68,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 104,
                    Nombre = "Bituima",
                    DepartamentoId = 25,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 105,
                    Nombre = "Boavita",
                    DepartamentoId = 15,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 106,
                    Nombre = "Bochalema",
                    DepartamentoId = 54,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 107,
                    Nombre = "Bogotá D.C.",
                    DepartamentoId = 11,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 108,
                    Nombre = "Bojacá",
                    DepartamentoId = 25,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 109,
                    Nombre = "Bojayá (Bellavista)",
                    DepartamentoId = 27,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 110,
                    Nombre = "Bolívar",
                    DepartamentoId = 5,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 111,
                    Nombre = "Bolívar",
                    DepartamentoId = 19,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 112,
                    Nombre = "Bolívar",
                    DepartamentoId = 68,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 113,
                    Nombre = "Bolívar",
                    DepartamentoId = 76,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 114,
                    Nombre = "Bosconia",
                    DepartamentoId = 20,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 115,
                    Nombre = "Boyacá",
                    DepartamentoId = 15,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 116,
                    Nombre = "BriceÃ±o",
                    DepartamentoId = 5,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 117,
                    Nombre = "BriceÃ±o",
                    DepartamentoId = 15,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 118,
                    Nombre = "Bucaramanga",
                    DepartamentoId = 68,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 119,
                    Nombre = "Bucarasica",
                    DepartamentoId = 54,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 120,
                    Nombre = "Buenaventura",
                    DepartamentoId = 76,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 121,
                    Nombre = "Buenavista",
                    DepartamentoId = 15,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 122,
                    Nombre = "Buenavista",
                    DepartamentoId = 23,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 123,
                    Nombre = "Buenavista",
                    DepartamentoId = 63,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 124,
                    Nombre = "Buenavista",
                    DepartamentoId = 70,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 125,
                    Nombre = "Buenos Aires",
                    DepartamentoId = 19,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 126,
                    Nombre = "Buesaco",
                    DepartamentoId = 52,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 127,
                    Nombre = "Buga",
                    DepartamentoId = 76,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 128,
                    Nombre = "Bugalagrande",
                    DepartamentoId = 76,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 129,
                    Nombre = "Burítica",
                    DepartamentoId = 5,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 130,
                    Nombre = "Busbanza",
                    DepartamentoId = 15,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 131,
                    Nombre = "Cabrera",
                    DepartamentoId = 25,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 132,
                    Nombre = "Cabrera",
                    DepartamentoId = 68,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 133,
                    Nombre = "Cabuyaro",
                    DepartamentoId = 50,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 134,
                    Nombre = "Cachipay",
                    DepartamentoId = 25,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 135,
                    Nombre = "Caicedo",
                    DepartamentoId = 5,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 136,
                    Nombre = "Caicedonia",
                    DepartamentoId = 76,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 137,
                    Nombre = "Caimito",
                    DepartamentoId = 70,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 138,
                    Nombre = "Cajamarca",
                    DepartamentoId = 73,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 139,
                    Nombre = "Cajibío",
                    DepartamentoId = 19,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 140,
                    Nombre = "Cajicá",
                    DepartamentoId = 25,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 141,
                    Nombre = "Calamar",
                    DepartamentoId = 13,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 142,
                    Nombre = "Calamar",
                    DepartamentoId = 95,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 143,
                    Nombre = "Calarcá",
                    DepartamentoId = 63,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 144,
                    Nombre = "Caldas",
                    DepartamentoId = 5,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 145,
                    Nombre = "Caldas",
                    DepartamentoId = 15,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 146,
                    Nombre = "Caldono",
                    DepartamentoId = 19,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 147,
                    Nombre = "California",
                    DepartamentoId = 68,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 148,
                    Nombre = "Calima (Darién)",
                    DepartamentoId = 76,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 149,
                    Nombre = "Caloto",
                    DepartamentoId = 19,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 150,
                    Nombre = "Calí",
                    DepartamentoId = 76,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 151,
                    Nombre = "Campamento",
                    DepartamentoId = 5,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 152,
                    Nombre = "Campo de la Cruz",
                    DepartamentoId = 8,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 153,
                    Nombre = "Campoalegre",
                    DepartamentoId = 41,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 154,
                    Nombre = "Campohermoso",
                    DepartamentoId = 15,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 155,
                    Nombre = "Canalete",
                    DepartamentoId = 23,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 156,
                    Nombre = "Candelaria",
                    DepartamentoId = 8,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 157,
                    Nombre = "Candelaria",
                    DepartamentoId = 76,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 158,
                    Nombre = "Cantagallo",
                    DepartamentoId = 13,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 159,
                    Nombre = "Cantón de San Pablo",
                    DepartamentoId = 27,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 160,
                    Nombre = "Caparrapí",
                    DepartamentoId = 25,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 161,
                    Nombre = "Capitanejo",
                    DepartamentoId = 68,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 162,
                    Nombre = "Caracolí",
                    DepartamentoId = 5,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 163,
                    Nombre = "Caramanta",
                    DepartamentoId = 5,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 164,
                    Nombre = "Carcasí",
                    DepartamentoId = 68,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 165,
                    Nombre = "Carepa",
                    DepartamentoId = 5,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 166,
                    Nombre = "Carmen de Apicalá",
                    DepartamentoId = 73,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 167,
                    Nombre = "Carmen de Carupa",
                    DepartamentoId = 25,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 168,
                    Nombre = "Carmen de Viboral",
                    DepartamentoId = 5,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 169,
                    Nombre = "Carmen del Darién (CURBARADÓ)",
                    DepartamentoId = 27,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 170,
                    Nombre = "Carolina",
                    DepartamentoId = 5,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 171,
                    Nombre = "Cartagena",
                    DepartamentoId = 13,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 172,
                    Nombre = "Cartagena del Chairá",
                    DepartamentoId = 18,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 173,
                    Nombre = "Cartago",
                    DepartamentoId = 76,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 174,
                    Nombre = "Carurú",
                    DepartamentoId = 97,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 175,
                    Nombre = "Casabianca",
                    DepartamentoId = 73,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 176,
                    Nombre = "Castilla la Nueva",
                    DepartamentoId = 50,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 177,
                    Nombre = "Caucasia",
                    DepartamentoId = 5,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 178,
                    Nombre = "CaÃ±asgordas",
                    DepartamentoId = 5,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 179,
                    Nombre = "Cepita",
                    DepartamentoId = 68,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 180,
                    Nombre = "Cereté",
                    DepartamentoId = 23,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 181,
                    Nombre = "Cerinza",
                    DepartamentoId = 15,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 182,
                    Nombre = "Cerrito",
                    DepartamentoId = 68,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 183,
                    Nombre = "Cerro San Antonio",
                    DepartamentoId = 47,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 184,
                    Nombre = "Chachaguí",
                    DepartamentoId = 52,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 185,
                    Nombre = "Chaguaní",
                    DepartamentoId = 25,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 186,
                    Nombre = "Chalán",
                    DepartamentoId = 70,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 187,
                    Nombre = "Chaparral",
                    DepartamentoId = 73,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 188,
                    Nombre = "Charalá",
                    DepartamentoId = 68,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 189,
                    Nombre = "Charta",
                    DepartamentoId = 68,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 190,
                    Nombre = "Chigorodó",
                    DepartamentoId = 5,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 191,
                    Nombre = "Chima",
                    DepartamentoId = 68,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 192,
                    Nombre = "Chimichagua",
                    DepartamentoId = 20,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 193,
                    Nombre = "Chimá",
                    DepartamentoId = 23,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 194,
                    Nombre = "Chinavita",
                    DepartamentoId = 15,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 195,
                    Nombre = "Chinchiná",
                    DepartamentoId = 17,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 196,
                    Nombre = "Chinácota",
                    DepartamentoId = 54,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 197,
                    Nombre = "Chinú",
                    DepartamentoId = 23,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 198,
                    Nombre = "Chipaque",
                    DepartamentoId = 25,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 199,
                    Nombre = "Chipatá",
                    DepartamentoId = 68,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 200,
                    Nombre = "Chiquinquirá",
                    DepartamentoId = 15,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 201,
                    Nombre = "Chiriguaná",
                    DepartamentoId = 20,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 202,
                    Nombre = "Chiscas",
                    DepartamentoId = 15,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 203,
                    Nombre = "Chita",
                    DepartamentoId = 15,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 204,
                    Nombre = "Chitagá",
                    DepartamentoId = 54,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 205,
                    Nombre = "Chitaraque",
                    DepartamentoId = 15,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 206,
                    Nombre = "Chivatá",
                    DepartamentoId = 15,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 207,
                    Nombre = "Chivolo",
                    DepartamentoId = 47,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 208,
                    Nombre = "Choachí",
                    DepartamentoId = 25,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 209,
                    Nombre = "Chocontá",
                    DepartamentoId = 25,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 210,
                    Nombre = "Chámeza",
                    DepartamentoId = 85,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 211,
                    Nombre = "Chía",
                    DepartamentoId = 25,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 212,
                    Nombre = "Chíquiza",
                    DepartamentoId = 15,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 213,
                    Nombre = "Chívor",
                    DepartamentoId = 15,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 214,
                    Nombre = "Cicuco",
                    DepartamentoId = 13,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 215,
                    Nombre = "Cimitarra",
                    DepartamentoId = 68,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 216,
                    Nombre = "Circasia",
                    DepartamentoId = 63,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 217,
                    Nombre = "Cisneros",
                    DepartamentoId = 5,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 218,
                    Nombre = "Ciénaga",
                    DepartamentoId = 15,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 219,
                    Nombre = "Ciénaga",
                    DepartamentoId = 47,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 220,
                    Nombre = "Ciénaga de Oro",
                    DepartamentoId = 23,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 221,
                    Nombre = "Clemencia",
                    DepartamentoId = 13,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 222,
                    Nombre = "Cocorná",
                    DepartamentoId = 5,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 223,
                    Nombre = "Coello",
                    DepartamentoId = 73,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 224,
                    Nombre = "Cogua",
                    DepartamentoId = 25,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 225,
                    Nombre = "Colombia",
                    DepartamentoId = 41,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 226,
                    Nombre = "Colosó (Ricaurte)",
                    DepartamentoId = 70,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 227,
                    Nombre = "Colón",
                    DepartamentoId = 86,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 228,
                    Nombre = "Colón (Génova)",
                    DepartamentoId = 52,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 229,
                    Nombre = "Concepción",
                    DepartamentoId = 5,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 230,
                    Nombre = "Concepción",
                    DepartamentoId = 68,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 231,
                    Nombre = "Concordia",
                    DepartamentoId = 5,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 232,
                    Nombre = "Concordia",
                    DepartamentoId = 47,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 233,
                    Nombre = "Condoto",
                    DepartamentoId = 27,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 234,
                    Nombre = "Confines",
                    DepartamentoId = 68,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 235,
                    Nombre = "Consaca",
                    DepartamentoId = 52,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 236,
                    Nombre = "Contadero",
                    DepartamentoId = 52,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 237,
                    Nombre = "Contratación",
                    DepartamentoId = 68,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 238,
                    Nombre = "Convención",
                    DepartamentoId = 54,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 239,
                    Nombre = "Copacabana",
                    DepartamentoId = 5,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 240,
                    Nombre = "Coper",
                    DepartamentoId = 15,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 241,
                    Nombre = "Cordobá",
                    DepartamentoId = 63,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 242,
                    Nombre = "Corinto",
                    DepartamentoId = 19,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 243,
                    Nombre = "Coromoro",
                    DepartamentoId = 68,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 244,
                    Nombre = "Corozal",
                    DepartamentoId = 70,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 245,
                    Nombre = "Corrales",
                    DepartamentoId = 15,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 246,
                    Nombre = "Cota",
                    DepartamentoId = 25,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 247,
                    Nombre = "Cotorra",
                    DepartamentoId = 23,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 248,
                    Nombre = "Covarachía",
                    DepartamentoId = 15,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 249,
                    Nombre = "CoveÃ±as",
                    DepartamentoId = 70,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 250,
                    Nombre = "Coyaima",
                    DepartamentoId = 73,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 251,
                    Nombre = "Cravo Norte",
                    DepartamentoId = 81,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 252,
                    Nombre = "Cuaspud (Carlosama)",
                    DepartamentoId = 52,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 253,
                    Nombre = "Cubarral",
                    DepartamentoId = 50,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 254,
                    Nombre = "Cubará",
                    DepartamentoId = 15,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 255,
                    Nombre = "Cucaita",
                    DepartamentoId = 15,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 256,
                    Nombre = "Cucunubá",
                    DepartamentoId = 25,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 257,
                    Nombre = "Cucutilla",
                    DepartamentoId = 54,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 258,
                    Nombre = "Cuitiva",
                    DepartamentoId = 15,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 259,
                    Nombre = "Cumaral",
                    DepartamentoId = 50,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 260,
                    Nombre = "Cumaribo",
                    DepartamentoId = 99,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 261,
                    Nombre = "Cumbal",
                    DepartamentoId = 52,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 262,
                    Nombre = "Cumbitara",
                    DepartamentoId = 52,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 263,
                    Nombre = "Cunday",
                    DepartamentoId = 73,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 264,
                    Nombre = "Curillo",
                    DepartamentoId = 18,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 265,
                    Nombre = "Curití",
                    DepartamentoId = 68,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 266,
                    Nombre = "Curumaní",
                    DepartamentoId = 20,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 267,
                    Nombre = "Cáceres",
                    DepartamentoId = 5,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 268,
                    Nombre = "Cáchira",
                    DepartamentoId = 54,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 269,
                    Nombre = "Cácota",
                    DepartamentoId = 54,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 270,
                    Nombre = "Cáqueza",
                    DepartamentoId = 25,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 271,
                    Nombre = "Cértegui",
                    DepartamentoId = 27,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 272,
                    Nombre = "Cómbita",
                    DepartamentoId = 15,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 273,
                    Nombre = "Córdoba",
                    DepartamentoId = 13,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 274,
                    Nombre = "Córdoba",
                    DepartamentoId = 52,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 275,
                    Nombre = "Cúcuta",
                    DepartamentoId = 54,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 276,
                    Nombre = "Dabeiba",
                    DepartamentoId = 5,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 277,
                    Nombre = "Dagua",
                    DepartamentoId = 76,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 278,
                    Nombre = "Dibulla",
                    DepartamentoId = 44,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 279,
                    Nombre = "Distracción",
                    DepartamentoId = 44,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 280,
                    Nombre = "Dolores",
                    DepartamentoId = 73,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 281,
                    Nombre = "Don Matías",
                    DepartamentoId = 5,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 282,
                    Nombre = "Dos Quebradas",
                    DepartamentoId = 66,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 283,
                    Nombre = "Duitama",
                    DepartamentoId = 15,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 284,
                    Nombre = "Durania",
                    DepartamentoId = 54,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 285,
                    Nombre = "Ebéjico",
                    DepartamentoId = 5,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 286,
                    Nombre = "El Bagre",
                    DepartamentoId = 5,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 287,
                    Nombre = "El Banco",
                    DepartamentoId = 47,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 288,
                    Nombre = "El Cairo",
                    DepartamentoId = 76,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 289,
                    Nombre = "El Calvario",
                    DepartamentoId = 50,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 290,
                    Nombre = "El Carmen",
                    DepartamentoId = 54,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 291,
                    Nombre = "El Carmen",
                    DepartamentoId = 68,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 292,
                    Nombre = "El Carmen de Atrato",
                    DepartamentoId = 27,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 293,
                    Nombre = "El Carmen de Bolívar",
                    DepartamentoId = 13,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 294,
                    Nombre = "El Castillo",
                    DepartamentoId = 50,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 295,
                    Nombre = "El Cerrito",
                    DepartamentoId = 76,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 296,
                    Nombre = "El Charco",
                    DepartamentoId = 52,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 297,
                    Nombre = "El Cocuy",
                    DepartamentoId = 15,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 298,
                    Nombre = "El Colegio",
                    DepartamentoId = 25,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 299,
                    Nombre = "El Copey",
                    DepartamentoId = 20,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 300,
                    Nombre = "El Doncello",
                    DepartamentoId = 18,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 301,
                    Nombre = "El Dorado",
                    DepartamentoId = 50,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 302,
                    Nombre = "El Dovio",
                    DepartamentoId = 76,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 303,
                    Nombre = "El Espino",
                    DepartamentoId = 15,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 304,
                    Nombre = "El Guacamayo",
                    DepartamentoId = 68,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 305,
                    Nombre = "El Guamo",
                    DepartamentoId = 13,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 306,
                    Nombre = "El Molino",
                    DepartamentoId = 44,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 307,
                    Nombre = "El Paso",
                    DepartamentoId = 20,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 308,
                    Nombre = "El Paujil",
                    DepartamentoId = 18,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 309,
                    Nombre = "El PeÃ±ol",
                    DepartamentoId = 52,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 310,
                    Nombre = "El PeÃ±on",
                    DepartamentoId = 13,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 311,
                    Nombre = "El PeÃ±on",
                    DepartamentoId = 68,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 312,
                    Nombre = "El PeÃ±ón",
                    DepartamentoId = 25,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 313,
                    Nombre = "El PiÃ±on",
                    DepartamentoId = 47,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 314,
                    Nombre = "El Playón",
                    DepartamentoId = 68,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 315,
                    Nombre = "El Retorno",
                    DepartamentoId = 95,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 316,
                    Nombre = "El Retén",
                    DepartamentoId = 47,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 317,
                    Nombre = "El Roble",
                    DepartamentoId = 70,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 318,
                    Nombre = "El Rosal",
                    DepartamentoId = 25,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 319,
                    Nombre = "El Rosario",
                    DepartamentoId = 52,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 320,
                    Nombre = "El Tablón de Gómez",
                    DepartamentoId = 52,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 321,
                    Nombre = "El Tambo",
                    DepartamentoId = 19,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 322,
                    Nombre = "El Tambo",
                    DepartamentoId = 52,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 323,
                    Nombre = "El Tarra",
                    DepartamentoId = 54,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 324,
                    Nombre = "El Zulia",
                    DepartamentoId = 54,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 325,
                    Nombre = "El Ã?guila",
                    DepartamentoId = 76,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 326,
                    Nombre = "Elías",
                    DepartamentoId = 41,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 327,
                    Nombre = "Encino",
                    DepartamentoId = 68,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 328,
                    Nombre = "Enciso",
                    DepartamentoId = 68,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 329,
                    Nombre = "Entrerríos",
                    DepartamentoId = 5,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 330,
                    Nombre = "Envigado",
                    DepartamentoId = 5,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 331,
                    Nombre = "Espinal",
                    DepartamentoId = 73,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 332,
                    Nombre = "Facatativá",
                    DepartamentoId = 25,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 333,
                    Nombre = "Falan",
                    DepartamentoId = 73,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 334,
                    Nombre = "Filadelfia",
                    DepartamentoId = 17,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 335,
                    Nombre = "Filandia",
                    DepartamentoId = 63,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 336,
                    Nombre = "Firavitoba",
                    DepartamentoId = 15,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 337,
                    Nombre = "Flandes",
                    DepartamentoId = 73,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 338,
                    Nombre = "Florencia",
                    DepartamentoId = 18,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 339,
                    Nombre = "Florencia",
                    DepartamentoId = 19,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 340,
                    Nombre = "Floresta",
                    DepartamentoId = 15,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 341,
                    Nombre = "Florida",
                    DepartamentoId = 76,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 342,
                    Nombre = "Floridablanca",
                    DepartamentoId = 68,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 343,
                    Nombre = "Florián",
                    DepartamentoId = 68,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 344,
                    Nombre = "Fonseca",
                    DepartamentoId = 44,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 345,
                    Nombre = "Fortúl",
                    DepartamentoId = 81,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 346,
                    Nombre = "Fosca",
                    DepartamentoId = 25,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 347,
                    Nombre = "Francisco Pizarro",
                    DepartamentoId = 52,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 348,
                    Nombre = "Fredonia",
                    DepartamentoId = 5,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 349,
                    Nombre = "Fresno",
                    DepartamentoId = 73,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 350,
                    Nombre = "Frontino",
                    DepartamentoId = 5,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 351,
                    Nombre = "Fuente de Oro",
                    DepartamentoId = 50,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 352,
                    Nombre = "Fundación",
                    DepartamentoId = 47,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 353,
                    Nombre = "Funes",
                    DepartamentoId = 52,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 354,
                    Nombre = "Funza",
                    DepartamentoId = 25,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 355,
                    Nombre = "Fusagasugá",
                    DepartamentoId = 25,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 356,
                    Nombre = "Fómeque",
                    DepartamentoId = 25,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 357,
                    Nombre = "Fúquene",
                    DepartamentoId = 25,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 358,
                    Nombre = "Gachalá",
                    DepartamentoId = 25,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 359,
                    Nombre = "Gachancipá",
                    DepartamentoId = 25,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 360,
                    Nombre = "Gachantivá",
                    DepartamentoId = 15,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 361,
                    Nombre = "Gachetá",
                    DepartamentoId = 25,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 362,
                    Nombre = "Galapa",
                    DepartamentoId = 8,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 363,
                    Nombre = "Galeras (Nueva Granada)",
                    DepartamentoId = 70,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 364,
                    Nombre = "Galán",
                    DepartamentoId = 68,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 365,
                    Nombre = "Gama",
                    DepartamentoId = 25,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 366,
                    Nombre = "Gamarra",
                    DepartamentoId = 20,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 367,
                    Nombre = "Garagoa",
                    DepartamentoId = 15,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 368,
                    Nombre = "Garzón",
                    DepartamentoId = 41,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 369,
                    Nombre = "Gigante",
                    DepartamentoId = 41,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 370,
                    Nombre = "Ginebra",
                    DepartamentoId = 76,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 371,
                    Nombre = "Giraldo",
                    DepartamentoId = 5,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 372,
                    Nombre = "Girardot",
                    DepartamentoId = 25,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 373,
                    Nombre = "Girardota",
                    DepartamentoId = 5,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 374,
                    Nombre = "Girón",
                    DepartamentoId = 68,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 375,
                    Nombre = "Gonzalez",
                    DepartamentoId = 20,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 376,
                    Nombre = "Gramalote",
                    DepartamentoId = 54,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 377,
                    Nombre = "Granada",
                    DepartamentoId = 5,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 378,
                    Nombre = "Granada",
                    DepartamentoId = 25,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 379,
                    Nombre = "Granada",
                    DepartamentoId = 50,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 380,
                    Nombre = "Guaca",
                    DepartamentoId = 68,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 381,
                    Nombre = "Guacamayas",
                    DepartamentoId = 15,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 382,
                    Nombre = "Guacarí",
                    DepartamentoId = 76,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 383,
                    Nombre = "Guachavés",
                    DepartamentoId = 52,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 384,
                    Nombre = "Guachené",
                    DepartamentoId = 19,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 385,
                    Nombre = "Guachetá",
                    DepartamentoId = 25,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 386,
                    Nombre = "Guachucal",
                    DepartamentoId = 52,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 387,
                    Nombre = "Guadalupe",
                    DepartamentoId = 5,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 388,
                    Nombre = "Guadalupe",
                    DepartamentoId = 41,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 389,
                    Nombre = "Guadalupe",
                    DepartamentoId = 68,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 390,
                    Nombre = "Guaduas",
                    DepartamentoId = 25,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 391,
                    Nombre = "Guaitarilla",
                    DepartamentoId = 52,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 392,
                    Nombre = "Gualmatán",
                    DepartamentoId = 52,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 393,
                    Nombre = "Guamal",
                    DepartamentoId = 47,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 394,
                    Nombre = "Guamal",
                    DepartamentoId = 50,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 395,
                    Nombre = "Guamo",
                    DepartamentoId = 73,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 396,
                    Nombre = "Guapota",
                    DepartamentoId = 68,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 397,
                    Nombre = "Guapí",
                    DepartamentoId = 19,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 398,
                    Nombre = "Guaranda",
                    DepartamentoId = 70,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 399,
                    Nombre = "Guarne",
                    DepartamentoId = 5,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 400,
                    Nombre = "Guasca",
                    DepartamentoId = 25,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 401,
                    Nombre = "Guatapé",
                    DepartamentoId = 5,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 402,
                    Nombre = "Guataquí",
                    DepartamentoId = 25,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 403,
                    Nombre = "Guatavita",
                    DepartamentoId = 25,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 404,
                    Nombre = "Guateque",
                    DepartamentoId = 15,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 405,
                    Nombre = "Guavatá",
                    DepartamentoId = 68,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 406,
                    Nombre = "Guayabal de Siquima",
                    DepartamentoId = 25,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 407,
                    Nombre = "Guayabetal",
                    DepartamentoId = 25,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 408,
                    Nombre = "Guayatá",
                    DepartamentoId = 15,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 409,
                    Nombre = "Guepsa",
                    DepartamentoId = 68,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 410,
                    Nombre = "Guicán",
                    DepartamentoId = 15,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 411,
                    Nombre = "Gutiérrez",
                    DepartamentoId = 25,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 412,
                    Nombre = "Guática",
                    DepartamentoId = 66,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 413,
                    Nombre = "Gámbita",
                    DepartamentoId = 68,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 414,
                    Nombre = "Gámeza",
                    DepartamentoId = 15,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 415,
                    Nombre = "Génova",
                    DepartamentoId = 63,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 416,
                    Nombre = "Gómez Plata",
                    DepartamentoId = 5,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 417,
                    Nombre = "Hacarí",
                    DepartamentoId = 54,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 418,
                    Nombre = "Hatillo de Loba",
                    DepartamentoId = 13,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 419,
                    Nombre = "Hato",
                    DepartamentoId = 68,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 420,
                    Nombre = "Hato Corozal",
                    DepartamentoId = 85,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 421,
                    Nombre = "Hatonuevo",
                    DepartamentoId = 44,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 422,
                    Nombre = "Heliconia",
                    DepartamentoId = 5,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 423,
                    Nombre = "Herrán",
                    DepartamentoId = 54,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 424,
                    Nombre = "Herveo",
                    DepartamentoId = 73,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 425,
                    Nombre = "Hispania",
                    DepartamentoId = 5,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 426,
                    Nombre = "Hobo",
                    DepartamentoId = 41,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 427,
                    Nombre = "Honda",
                    DepartamentoId = 73,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 428,
                    Nombre = "Ibagué",
                    DepartamentoId = 73,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 429,
                    Nombre = "Icononzo",
                    DepartamentoId = 73,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 430,
                    Nombre = "Iles",
                    DepartamentoId = 52,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 431,
                    Nombre = "Imúes",
                    DepartamentoId = 52,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 432,
                    Nombre = "Inzá",
                    DepartamentoId = 19,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 433,
                    Nombre = "Inírida",
                    DepartamentoId = 94,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 434,
                    Nombre = "Ipiales",
                    DepartamentoId = 52,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 435,
                    Nombre = "Isnos",
                    DepartamentoId = 41,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 436,
                    Nombre = "Istmina",
                    DepartamentoId = 27,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 437,
                    Nombre = "Itagüí",
                    DepartamentoId = 5,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 438,
                    Nombre = "Ituango",
                    DepartamentoId = 5,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 439,
                    Nombre = "Izá",
                    DepartamentoId = 15,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 440,
                    Nombre = "Jambaló",
                    DepartamentoId = 19,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 441,
                    Nombre = "Jamundí",
                    DepartamentoId = 76,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 442,
                    Nombre = "Jardín",
                    DepartamentoId = 5,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 443,
                    Nombre = "Jenesano",
                    DepartamentoId = 15,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 444,
                    Nombre = "Jericó",
                    DepartamentoId = 5,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 445,
                    Nombre = "Jericó",
                    DepartamentoId = 15,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 446,
                    Nombre = "Jerusalén",
                    DepartamentoId = 25,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 447,
                    Nombre = "Jesús María",
                    DepartamentoId = 68,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 448,
                    Nombre = "Jordán",
                    DepartamentoId = 68,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 449,
                    Nombre = "Juan de Acosta",
                    DepartamentoId = 8,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 450,
                    Nombre = "Junín",
                    DepartamentoId = 25,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 451,
                    Nombre = "Juradó",
                    DepartamentoId = 27,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 452,
                    Nombre = "La Apartada y La Frontera",
                    DepartamentoId = 23,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 453,
                    Nombre = "La Argentina",
                    DepartamentoId = 41,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 454,
                    Nombre = "La Belleza",
                    DepartamentoId = 68,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 455,
                    Nombre = "La Calera",
                    DepartamentoId = 25,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 456,
                    Nombre = "La Capilla",
                    DepartamentoId = 15,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 457,
                    Nombre = "La Ceja",
                    DepartamentoId = 5,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 458,
                    Nombre = "La Celia",
                    DepartamentoId = 66,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 459,
                    Nombre = "La Cruz",
                    DepartamentoId = 52,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 460,
                    Nombre = "La Cumbre",
                    DepartamentoId = 76,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 461,
                    Nombre = "La Dorada",
                    DepartamentoId = 17,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 462,
                    Nombre = "La Esperanza",
                    DepartamentoId = 54,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 463,
                    Nombre = "La Estrella",
                    DepartamentoId = 5,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 464,
                    Nombre = "La Florida",
                    DepartamentoId = 52,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 465,
                    Nombre = "La Gloria",
                    DepartamentoId = 20,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 466,
                    Nombre = "La Jagua de Ibirico",
                    DepartamentoId = 20,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 467,
                    Nombre = "La Jagua del Pilar",
                    DepartamentoId = 44,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 468,
                    Nombre = "La Llanada",
                    DepartamentoId = 52,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 469,
                    Nombre = "La Macarena",
                    DepartamentoId = 50,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 470,
                    Nombre = "La Merced",
                    DepartamentoId = 17,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 471,
                    Nombre = "La Mesa",
                    DepartamentoId = 25,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 472,
                    Nombre = "La MontaÃ±ita",
                    DepartamentoId = 18,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 473,
                    Nombre = "La Palma",
                    DepartamentoId = 25,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 474,
                    Nombre = "La Paz",
                    DepartamentoId = 68,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 475,
                    Nombre = "La Paz (Robles)",
                    DepartamentoId = 20,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 476,
                    Nombre = "La PeÃ±a",
                    DepartamentoId = 25,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 477,
                    Nombre = "La Pintada",
                    DepartamentoId = 5,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 478,
                    Nombre = "La Plata",
                    DepartamentoId = 41,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 479,
                    Nombre = "La Playa",
                    DepartamentoId = 54,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 480,
                    Nombre = "La Primavera",
                    DepartamentoId = 99,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 481,
                    Nombre = "La Salina",
                    DepartamentoId = 85,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 482,
                    Nombre = "La Sierra",
                    DepartamentoId = 19,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 483,
                    Nombre = "La Tebaida",
                    DepartamentoId = 63,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 484,
                    Nombre = "La Tola",
                    DepartamentoId = 52,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 485,
                    Nombre = "La Unión",
                    DepartamentoId = 5,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 486,
                    Nombre = "La Unión",
                    DepartamentoId = 52,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 487,
                    Nombre = "La Unión",
                    DepartamentoId = 70,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 488,
                    Nombre = "La Unión",
                    DepartamentoId = 76,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 489,
                    Nombre = "La Uvita",
                    DepartamentoId = 15,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 490,
                    Nombre = "La Vega",
                    DepartamentoId = 19,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 491,
                    Nombre = "La Vega",
                    DepartamentoId = 25,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 492,
                    Nombre = "La Victoria",
                    DepartamentoId = 15,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 493,
                    Nombre = "La Victoria",
                    DepartamentoId = 17,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 494,
                    Nombre = "La Victoria",
                    DepartamentoId = 76,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 495,
                    Nombre = "La Virginia",
                    DepartamentoId = 66,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 496,
                    Nombre = "Labateca",
                    DepartamentoId = 54,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 497,
                    Nombre = "Labranzagrande",
                    DepartamentoId = 15,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 498,
                    Nombre = "Landázuri",
                    DepartamentoId = 68,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 499,
                    Nombre = "Lebrija",
                    DepartamentoId = 68,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 500,
                    Nombre = "Leiva",
                    DepartamentoId = 52,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 501,
                    Nombre = "Lejanías",
                    DepartamentoId = 50,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 502,
                    Nombre = "Lenguazaque",
                    DepartamentoId = 25,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 503,
                    Nombre = "Leticia",
                    DepartamentoId = 91,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 504,
                    Nombre = "Liborina",
                    DepartamentoId = 5,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 505,
                    Nombre = "Linares",
                    DepartamentoId = 52,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 506,
                    Nombre = "Lloró",
                    DepartamentoId = 27,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 507,
                    Nombre = "Lorica",
                    DepartamentoId = 23,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 508,
                    Nombre = "Los Córdobas",
                    DepartamentoId = 23,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 509,
                    Nombre = "Los Palmitos",
                    DepartamentoId = 70,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 510,
                    Nombre = "Los Patios",
                    DepartamentoId = 54,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 511,
                    Nombre = "Los Santos",
                    DepartamentoId = 68,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 512,
                    Nombre = "Lourdes",
                    DepartamentoId = 54,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 513,
                    Nombre = "Luruaco",
                    DepartamentoId = 8,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 514,
                    Nombre = "Lérida",
                    DepartamentoId = 73,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 515,
                    Nombre = "Líbano",
                    DepartamentoId = 73,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 516,
                    Nombre = "López (Micay)",
                    DepartamentoId = 19,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 517,
                    Nombre = "Macanal",
                    DepartamentoId = 15,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 518,
                    Nombre = "Macaravita",
                    DepartamentoId = 68,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 519,
                    Nombre = "Maceo",
                    DepartamentoId = 5,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 520,
                    Nombre = "Machetá",
                    DepartamentoId = 25,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 521,
                    Nombre = "Madrid",
                    DepartamentoId = 25,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 522,
                    Nombre = "Magangué",
                    DepartamentoId = 13,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 523,
                    Nombre = "MagÃ¼i (Payán)",
                    DepartamentoId = 52,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 524,
                    Nombre = "Mahates",
                    DepartamentoId = 13,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 525,
                    Nombre = "Maicao",
                    DepartamentoId = 44,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 526,
                    Nombre = "Majagual",
                    DepartamentoId = 70,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 527,
                    Nombre = "Malambo",
                    DepartamentoId = 8,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 528,
                    Nombre = "Mallama (Piedrancha)",
                    DepartamentoId = 52,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 529,
                    Nombre = "Manatí",
                    DepartamentoId = 8,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 530,
                    Nombre = "Manaure",
                    DepartamentoId = 44,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 531,
                    Nombre = "Manaure Balcón del Cesar",
                    DepartamentoId = 20,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 532,
                    Nombre = "Manizales",
                    DepartamentoId = 17,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 533,
                    Nombre = "Manta",
                    DepartamentoId = 25,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 534,
                    Nombre = "Manzanares",
                    DepartamentoId = 17,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 535,
                    Nombre = "Maní",
                    DepartamentoId = 85,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 536,
                    Nombre = "Mapiripan",
                    DepartamentoId = 50,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 537,
                    Nombre = "Margarita",
                    DepartamentoId = 13,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 538,
                    Nombre = "Marinilla",
                    DepartamentoId = 5,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 539,
                    Nombre = "Maripí",
                    DepartamentoId = 15,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 540,
                    Nombre = "Mariquita",
                    DepartamentoId = 73,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 541,
                    Nombre = "Marmato",
                    DepartamentoId = 17,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 542,
                    Nombre = "Marquetalia",
                    DepartamentoId = 17,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 543,
                    Nombre = "Marsella",
                    DepartamentoId = 66,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 544,
                    Nombre = "Marulanda",
                    DepartamentoId = 17,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 545,
                    Nombre = "María la Baja",
                    DepartamentoId = 13,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 546,
                    Nombre = "Matanza",
                    DepartamentoId = 68,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 547,
                    Nombre = "Medellín",
                    DepartamentoId = 5,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 548,
                    Nombre = "Medina",
                    DepartamentoId = 25,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 549,
                    Nombre = "Medio Atrato",
                    DepartamentoId = 27,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 550,
                    Nombre = "Medio Baudó",
                    DepartamentoId = 27,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 551,
                    Nombre = "Medio San Juan (ANDAGOYA)",
                    DepartamentoId = 27,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 552,
                    Nombre = "Melgar",
                    DepartamentoId = 73,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 553,
                    Nombre = "Mercaderes",
                    DepartamentoId = 19,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 554,
                    Nombre = "Mesetas",
                    DepartamentoId = 50,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 555,
                    Nombre = "Milán",
                    DepartamentoId = 18,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 556,
                    Nombre = "Miraflores",
                    DepartamentoId = 15,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 557,
                    Nombre = "Miraflores",
                    DepartamentoId = 95,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 558,
                    Nombre = "Miranda",
                    DepartamentoId = 19,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 559,
                    Nombre = "Mistrató",
                    DepartamentoId = 66,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 560,
                    Nombre = "Mitú",
                    DepartamentoId = 97,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 561,
                    Nombre = "Mocoa",
                    DepartamentoId = 86,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 562,
                    Nombre = "Mogotes",
                    DepartamentoId = 68,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 563,
                    Nombre = "Molagavita",
                    DepartamentoId = 68,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 564,
                    Nombre = "Momil",
                    DepartamentoId = 23,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 565,
                    Nombre = "Mompós",
                    DepartamentoId = 13,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 566,
                    Nombre = "Mongua",
                    DepartamentoId = 15,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 567,
                    Nombre = "Monguí",
                    DepartamentoId = 15,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 568,
                    Nombre = "Moniquirá",
                    DepartamentoId = 15,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 569,
                    Nombre = "Montebello",
                    DepartamentoId = 5,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 570,
                    Nombre = "Montecristo",
                    DepartamentoId = 13,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 571,
                    Nombre = "Montelíbano",
                    DepartamentoId = 23,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 572,
                    Nombre = "Montenegro",
                    DepartamentoId = 63,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 573,
                    Nombre = "Monteria",
                    DepartamentoId = 23,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 574,
                    Nombre = "Monterrey",
                    DepartamentoId = 85,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 575,
                    Nombre = "Morales",
                    DepartamentoId = 13,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 576,
                    Nombre = "Morales",
                    DepartamentoId = 19,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 577,
                    Nombre = "Morelia",
                    DepartamentoId = 18,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 578,
                    Nombre = "Morroa",
                    DepartamentoId = 70,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 579,
                    Nombre = "Mosquera",
                    DepartamentoId = 25,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 580,
                    Nombre = "Mosquera",
                    DepartamentoId = 52,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 581,
                    Nombre = "Motavita",
                    DepartamentoId = 15,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 582,
                    Nombre = "MoÃ±itos",
                    DepartamentoId = 23,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 583,
                    Nombre = "Murillo",
                    DepartamentoId = 73,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 584,
                    Nombre = "Murindó",
                    DepartamentoId = 5,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 585,
                    Nombre = "Mutatá",
                    DepartamentoId = 5,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 586,
                    Nombre = "Mutiscua",
                    DepartamentoId = 54,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 587,
                    Nombre = "Muzo",
                    DepartamentoId = 15,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 588,
                    Nombre = "Málaga",
                    DepartamentoId = 68,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 589,
                    Nombre = "NariÃ±o",
                    DepartamentoId = 5,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 590,
                    Nombre = "NariÃ±o",
                    DepartamentoId = 25,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 591,
                    Nombre = "NariÃ±o",
                    DepartamentoId = 52,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 592,
                    Nombre = "Natagaima",
                    DepartamentoId = 73,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 593,
                    Nombre = "Nechí",
                    DepartamentoId = 5,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 594,
                    Nombre = "Necoclí",
                    DepartamentoId = 5,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 595,
                    Nombre = "Neira",
                    DepartamentoId = 17,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 596,
                    Nombre = "Neiva",
                    DepartamentoId = 41,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 597,
                    Nombre = "Nemocón",
                    DepartamentoId = 25,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 598,
                    Nombre = "Nilo",
                    DepartamentoId = 25,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 599,
                    Nombre = "Nimaima",
                    DepartamentoId = 25,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 600,
                    Nombre = "Nobsa",
                    DepartamentoId = 15,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 601,
                    Nombre = "Nocaima",
                    DepartamentoId = 25,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 602,
                    Nombre = "Norcasia",
                    DepartamentoId = 17,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 603,
                    Nombre = "Norosí",
                    DepartamentoId = 13,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 604,
                    Nombre = "Novita",
                    DepartamentoId = 27,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 605,
                    Nombre = "Nueva Granada",
                    DepartamentoId = 47,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 606,
                    Nombre = "Nuevo Colón",
                    DepartamentoId = 15,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 607,
                    Nombre = "Nunchía",
                    DepartamentoId = 85,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 608,
                    Nombre = "Nuquí",
                    DepartamentoId = 27,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 609,
                    Nombre = "Nátaga",
                    DepartamentoId = 41,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 610,
                    Nombre = "Obando",
                    DepartamentoId = 76,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 611,
                    Nombre = "Ocamonte",
                    DepartamentoId = 68,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 612,
                    Nombre = "OcaÃ±a",
                    DepartamentoId = 54,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 613,
                    Nombre = "Oiba",
                    DepartamentoId = 68,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 614,
                    Nombre = "Oicatá",
                    DepartamentoId = 15,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 615,
                    Nombre = "Olaya",
                    DepartamentoId = 5,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 616,
                    Nombre = "Olaya Herrera",
                    DepartamentoId = 52,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 617,
                    Nombre = "Onzaga",
                    DepartamentoId = 68,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 618,
                    Nombre = "Oporapa",
                    DepartamentoId = 41,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 619,
                    Nombre = "Orito",
                    DepartamentoId = 86,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 620,
                    Nombre = "Orocué",
                    DepartamentoId = 85,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 621,
                    Nombre = "Ortega",
                    DepartamentoId = 73,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 622,
                    Nombre = "Ospina",
                    DepartamentoId = 52,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 623,
                    Nombre = "Otanche",
                    DepartamentoId = 15,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 624,
                    Nombre = "Ovejas",
                    DepartamentoId = 70,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 625,
                    Nombre = "Pachavita",
                    DepartamentoId = 15,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 626,
                    Nombre = "Pacho",
                    DepartamentoId = 25,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 627,
                    Nombre = "Padilla",
                    DepartamentoId = 19,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 628,
                    Nombre = "Paicol",
                    DepartamentoId = 41,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 629,
                    Nombre = "Pailitas",
                    DepartamentoId = 20,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 630,
                    Nombre = "Paime",
                    DepartamentoId = 25,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 631,
                    Nombre = "Paipa",
                    DepartamentoId = 15,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 632,
                    Nombre = "Pajarito",
                    DepartamentoId = 15,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 633,
                    Nombre = "Palermo",
                    DepartamentoId = 41,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 634,
                    Nombre = "Palestina",
                    DepartamentoId = 17,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 635,
                    Nombre = "Palestina",
                    DepartamentoId = 41,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 636,
                    Nombre = "Palmar",
                    DepartamentoId = 68,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 637,
                    Nombre = "Palmar de Varela",
                    DepartamentoId = 8,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 638,
                    Nombre = "Palmas del Socorro",
                    DepartamentoId = 68,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 639,
                    Nombre = "Palmira",
                    DepartamentoId = 76,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 640,
                    Nombre = "Palmito",
                    DepartamentoId = 70,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 641,
                    Nombre = "Palocabildo",
                    DepartamentoId = 73,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 642,
                    Nombre = "Pamplona",
                    DepartamentoId = 54,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 643,
                    Nombre = "Pamplonita",
                    DepartamentoId = 54,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 644,
                    Nombre = "Pandi",
                    DepartamentoId = 25,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 645,
                    Nombre = "Panqueba",
                    DepartamentoId = 15,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 646,
                    Nombre = "Paratebueno",
                    DepartamentoId = 25,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 647,
                    Nombre = "Pasca",
                    DepartamentoId = 25,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 648,
                    Nombre = "Patía (El Bordo)",
                    DepartamentoId = 19,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 649,
                    Nombre = "Pauna",
                    DepartamentoId = 15,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 650,
                    Nombre = "Paya",
                    DepartamentoId = 15,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 651,
                    Nombre = "Paz de Ariporo",
                    DepartamentoId = 85,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 652,
                    Nombre = "Paz de Río",
                    DepartamentoId = 15,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 653,
                    Nombre = "Pedraza",
                    DepartamentoId = 47,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 654,
                    Nombre = "Pelaya",
                    DepartamentoId = 20,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 655,
                    Nombre = "Pensilvania",
                    DepartamentoId = 17,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 656,
                    Nombre = "Peque",
                    DepartamentoId = 5,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 657,
                    Nombre = "Pereira",
                    DepartamentoId = 66,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 658,
                    Nombre = "Pesca",
                    DepartamentoId = 15,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 659,
                    Nombre = "PeÃ±ol",
                    DepartamentoId = 5,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 660,
                    Nombre = "Piamonte",
                    DepartamentoId = 19,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 661,
                    Nombre = "Pie de Cuesta",
                    DepartamentoId = 68,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 662,
                    Nombre = "Piedras",
                    DepartamentoId = 73,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 663,
                    Nombre = "Piendamó",
                    DepartamentoId = 19,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 664,
                    Nombre = "Pijao",
                    DepartamentoId = 63,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 665,
                    Nombre = "PijiÃ±o",
                    DepartamentoId = 47,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 666,
                    Nombre = "Pinchote",
                    DepartamentoId = 68,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 667,
                    Nombre = "Pinillos",
                    DepartamentoId = 13,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 668,
                    Nombre = "Piojo",
                    DepartamentoId = 8,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 669,
                    Nombre = "Pisva",
                    DepartamentoId = 15,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 670,
                    Nombre = "Pital",
                    DepartamentoId = 41,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 671,
                    Nombre = "Pitalito",
                    DepartamentoId = 41,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 672,
                    Nombre = "Pivijay",
                    DepartamentoId = 47,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 673,
                    Nombre = "Planadas",
                    DepartamentoId = 73,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 674,
                    Nombre = "Planeta Rica",
                    DepartamentoId = 23,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 675,
                    Nombre = "Plato",
                    DepartamentoId = 47,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 676,
                    Nombre = "Policarpa",
                    DepartamentoId = 52,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 677,
                    Nombre = "Polonuevo",
                    DepartamentoId = 8,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 678,
                    Nombre = "Ponedera",
                    DepartamentoId = 8,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 679,
                    Nombre = "Popayán",
                    DepartamentoId = 19,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 680,
                    Nombre = "Pore",
                    DepartamentoId = 85,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 681,
                    Nombre = "Potosí",
                    DepartamentoId = 52,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 682,
                    Nombre = "Pradera",
                    DepartamentoId = 76,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 683,
                    Nombre = "Prado",
                    DepartamentoId = 73,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 684,
                    Nombre = "Providencia",
                    DepartamentoId = 52,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 685,
                    Nombre = "Providencia",
                    DepartamentoId = 88,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 686,
                    Nombre = "Pueblo Bello",
                    DepartamentoId = 20,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 687,
                    Nombre = "Pueblo Nuevo",
                    DepartamentoId = 23,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 688,
                    Nombre = "Pueblo Rico",
                    DepartamentoId = 66,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 689,
                    Nombre = "Pueblorrico",
                    DepartamentoId = 5,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 690,
                    Nombre = "Puebloviejo",
                    DepartamentoId = 47,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 691,
                    Nombre = "Puente Nacional",
                    DepartamentoId = 68,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 692,
                    Nombre = "Puerres",
                    DepartamentoId = 52,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 693,
                    Nombre = "Puerto Asís",
                    DepartamentoId = 86,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 694,
                    Nombre = "Puerto Berrío",
                    DepartamentoId = 5,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 695,
                    Nombre = "Puerto Boyacá",
                    DepartamentoId = 15,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 696,
                    Nombre = "Puerto Caicedo",
                    DepartamentoId = 86,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 697,
                    Nombre = "Puerto CarreÃ±o",
                    DepartamentoId = 99,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 698,
                    Nombre = "Puerto Colombia",
                    DepartamentoId = 8,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 699,
                    Nombre = "Puerto Concordia",
                    DepartamentoId = 50,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 700,
                    Nombre = "Puerto Escondido",
                    DepartamentoId = 23,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 701,
                    Nombre = "Puerto Gaitán",
                    DepartamentoId = 50,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 702,
                    Nombre = "Puerto Guzmán",
                    DepartamentoId = 86,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 703,
                    Nombre = "Puerto Leguízamo",
                    DepartamentoId = 86,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 704,
                    Nombre = "Puerto Libertador",
                    DepartamentoId = 23,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 705,
                    Nombre = "Puerto Lleras",
                    DepartamentoId = 50,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 706,
                    Nombre = "Puerto López",
                    DepartamentoId = 50,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 707,
                    Nombre = "Puerto Nare",
                    DepartamentoId = 5,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 708,
                    Nombre = "Puerto NariÃ±o",
                    DepartamentoId = 91,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 709,
                    Nombre = "Puerto Parra",
                    DepartamentoId = 68,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 710,
                    Nombre = "Puerto Rico",
                    DepartamentoId = 18,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 711,
                    Nombre = "Puerto Rico",
                    DepartamentoId = 50,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 712,
                    Nombre = "Puerto Rondón",
                    DepartamentoId = 81,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 713,
                    Nombre = "Puerto Salgar",
                    DepartamentoId = 25,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 714,
                    Nombre = "Puerto Santander",
                    DepartamentoId = 54,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 715,
                    Nombre = "Puerto Tejada",
                    DepartamentoId = 19,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 716,
                    Nombre = "Puerto Triunfo",
                    DepartamentoId = 5,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 717,
                    Nombre = "Puerto Wilches",
                    DepartamentoId = 68,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 718,
                    Nombre = "Pulí",
                    DepartamentoId = 25,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 719,
                    Nombre = "Pupiales",
                    DepartamentoId = 52,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 720,
                    Nombre = "Puracé (Coconuco)",
                    DepartamentoId = 19,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 721,
                    Nombre = "Purificación",
                    DepartamentoId = 73,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 722,
                    Nombre = "Purísima",
                    DepartamentoId = 23,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 723,
                    Nombre = "Pácora",
                    DepartamentoId = 17,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 724,
                    Nombre = "Páez",
                    DepartamentoId = 15,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 725,
                    Nombre = "Páez (Belalcazar)",
                    DepartamentoId = 19,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 726,
                    Nombre = "Páramo",
                    DepartamentoId = 68,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 727,
                    Nombre = "Quebradanegra",
                    DepartamentoId = 25,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 728,
                    Nombre = "Quetame",
                    DepartamentoId = 25,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 729,
                    Nombre = "Quibdó",
                    DepartamentoId = 27,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 730,
                    Nombre = "Quimbaya",
                    DepartamentoId = 63,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 731,
                    Nombre = "Quinchía",
                    DepartamentoId = 66,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 732,
                    Nombre = "Quipama",
                    DepartamentoId = 15,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 733,
                    Nombre = "Quipile",
                    DepartamentoId = 25,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 734,
                    Nombre = "Ragonvalia",
                    DepartamentoId = 54,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 735,
                    Nombre = "Ramiriquí",
                    DepartamentoId = 15,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 736,
                    Nombre = "Recetor",
                    DepartamentoId = 85,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 737,
                    Nombre = "Regidor",
                    DepartamentoId = 13,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 738,
                    Nombre = "Remedios",
                    DepartamentoId = 5,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 739,
                    Nombre = "Remolino",
                    DepartamentoId = 47,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 740,
                    Nombre = "Repelón",
                    DepartamentoId = 8,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 741,
                    Nombre = "Restrepo",
                    DepartamentoId = 50,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 742,
                    Nombre = "Restrepo",
                    DepartamentoId = 76,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 743,
                    Nombre = "Retiro",
                    DepartamentoId = 5,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 744,
                    Nombre = "Ricaurte",
                    DepartamentoId = 25,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 745,
                    Nombre = "Ricaurte",
                    DepartamentoId = 52,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 746,
                    Nombre = "Rio Negro",
                    DepartamentoId = 68,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 747,
                    Nombre = "Rioblanco",
                    DepartamentoId = 73,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 748,
                    Nombre = "Riofrío",
                    DepartamentoId = 76,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 749,
                    Nombre = "Riohacha",
                    DepartamentoId = 44,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 750,
                    Nombre = "Risaralda",
                    DepartamentoId = 17,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 751,
                    Nombre = "Rivera",
                    DepartamentoId = 41,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 752,
                    Nombre = "Roberto Payán (San José)",
                    DepartamentoId = 52,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 753,
                    Nombre = "Roldanillo",
                    DepartamentoId = 76,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 754,
                    Nombre = "Roncesvalles",
                    DepartamentoId = 73,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 755,
                    Nombre = "Rondón",
                    DepartamentoId = 15,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 756,
                    Nombre = "Rosas",
                    DepartamentoId = 19,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 757,
                    Nombre = "Rovira",
                    DepartamentoId = 73,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 758,
                    Nombre = "Ráquira",
                    DepartamentoId = 15,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 759,
                    Nombre = "Río Iró",
                    DepartamentoId = 27,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 760,
                    Nombre = "Río Quito",
                    DepartamentoId = 27,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 761,
                    Nombre = "Río Sucio",
                    DepartamentoId = 17,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 762,
                    Nombre = "Río Viejo",
                    DepartamentoId = 13,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 763,
                    Nombre = "Río de oro",
                    DepartamentoId = 20,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 764,
                    Nombre = "Ríonegro",
                    DepartamentoId = 5,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 765,
                    Nombre = "Ríosucio",
                    DepartamentoId = 27,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 766,
                    Nombre = "Sabana de Torres",
                    DepartamentoId = 68,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 767,
                    Nombre = "Sabanagrande",
                    DepartamentoId = 8,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 768,
                    Nombre = "Sabanalarga",
                    DepartamentoId = 5,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 769,
                    Nombre = "Sabanalarga",
                    DepartamentoId = 8,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 770,
                    Nombre = "Sabanalarga",
                    DepartamentoId = 85,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 771,
                    Nombre = "Sabanas de San Angel (SAN ANGEL)",
                    DepartamentoId = 47,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 772,
                    Nombre = "Sabaneta",
                    DepartamentoId = 5,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 773,
                    Nombre = "Saboyá",
                    DepartamentoId = 15,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 774,
                    Nombre = "Sahagún",
                    DepartamentoId = 23,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 775,
                    Nombre = "Saladoblanco",
                    DepartamentoId = 41,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 776,
                    Nombre = "Salamina",
                    DepartamentoId = 17,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 777,
                    Nombre = "Salamina",
                    DepartamentoId = 47,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 778,
                    Nombre = "Salazar",
                    DepartamentoId = 54,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 779,
                    Nombre = "SaldaÃ±a",
                    DepartamentoId = 73,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 780,
                    Nombre = "Salento",
                    DepartamentoId = 63,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 781,
                    Nombre = "Salgar",
                    DepartamentoId = 5,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 782,
                    Nombre = "Samacá",
                    DepartamentoId = 15,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 783,
                    Nombre = "Samaniego",
                    DepartamentoId = 52,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 784,
                    Nombre = "Samaná",
                    DepartamentoId = 17,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 785,
                    Nombre = "Sampués",
                    DepartamentoId = 70,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 786,
                    Nombre = "San Agustín",
                    DepartamentoId = 41,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 787,
                    Nombre = "San Alberto",
                    DepartamentoId = 20,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 788,
                    Nombre = "San Andrés",
                    DepartamentoId = 68,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 789,
                    Nombre = "San Andrés Sotavento",
                    DepartamentoId = 23,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 790,
                    Nombre = "San Andrés de Cuerquía",
                    DepartamentoId = 5,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 791,
                    Nombre = "San Antero",
                    DepartamentoId = 23,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 792,
                    Nombre = "San Antonio",
                    DepartamentoId = 73,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 793,
                    Nombre = "San Antonio de Tequendama",
                    DepartamentoId = 25,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 794,
                    Nombre = "San Benito",
                    DepartamentoId = 68,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 795,
                    Nombre = "San Benito Abad",
                    DepartamentoId = 70,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 796,
                    Nombre = "San Bernardo",
                    DepartamentoId = 25,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 797,
                    Nombre = "San Bernardo",
                    DepartamentoId = 52,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 798,
                    Nombre = "San Bernardo del Viento",
                    DepartamentoId = 23,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 799,
                    Nombre = "San Calixto",
                    DepartamentoId = 54,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 800,
                    Nombre = "San Carlos",
                    DepartamentoId = 5,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 801,
                    Nombre = "San Carlos",
                    DepartamentoId = 23,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 802,
                    Nombre = "San Carlos de Guaroa",
                    DepartamentoId = 50,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 803,
                    Nombre = "San Cayetano",
                    DepartamentoId = 25,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 804,
                    Nombre = "San Cayetano",
                    DepartamentoId = 54,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 805,
                    Nombre = "San Cristobal",
                    DepartamentoId = 13,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 806,
                    Nombre = "San Diego",
                    DepartamentoId = 20,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 807,
                    Nombre = "San Eduardo",
                    DepartamentoId = 15,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 808,
                    Nombre = "San Estanislao",
                    DepartamentoId = 13,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 809,
                    Nombre = "San Fernando",
                    DepartamentoId = 13,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 810,
                    Nombre = "San Francisco",
                    DepartamentoId = 5,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 811,
                    Nombre = "San Francisco",
                    DepartamentoId = 25,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 812,
                    Nombre = "San Francisco",
                    DepartamentoId = 86,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 813,
                    Nombre = "San Gíl",
                    DepartamentoId = 68,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 814,
                    Nombre = "San Jacinto",
                    DepartamentoId = 13,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 815,
                    Nombre = "San Jacinto del Cauca",
                    DepartamentoId = 13,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 816,
                    Nombre = "San Jerónimo",
                    DepartamentoId = 5,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 817,
                    Nombre = "San Joaquín",
                    DepartamentoId = 68,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 818,
                    Nombre = "San José",
                    DepartamentoId = 17,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 819,
                    Nombre = "San José de Miranda",
                    DepartamentoId = 68,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 820,
                    Nombre = "San José de MontaÃ±a",
                    DepartamentoId = 5,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 821,
                    Nombre = "San José de Pare",
                    DepartamentoId = 15,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 822,
                    Nombre = "San José de Uré",
                    DepartamentoId = 23,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 823,
                    Nombre = "San José del Fragua",
                    DepartamentoId = 18,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 824,
                    Nombre = "San José del Guaviare",
                    DepartamentoId = 95,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 825,
                    Nombre = "San José del Palmar",
                    DepartamentoId = 27,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 826,
                    Nombre = "San Juan de Arama",
                    DepartamentoId = 50,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 827,
                    Nombre = "San Juan de Betulia",
                    DepartamentoId = 70,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 828,
                    Nombre = "San Juan de Nepomuceno",
                    DepartamentoId = 13,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 829,
                    Nombre = "San Juan de Pasto",
                    DepartamentoId = 52,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 830,
                    Nombre = "San Juan de Río Seco",
                    DepartamentoId = 25,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 831,
                    Nombre = "San Juan de Urabá",
                    DepartamentoId = 5,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 832,
                    Nombre = "San Juan del Cesar",
                    DepartamentoId = 44,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 833,
                    Nombre = "San Juanito",
                    DepartamentoId = 50,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 834,
                    Nombre = "San Lorenzo",
                    DepartamentoId = 52,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 835,
                    Nombre = "San Luis",
                    DepartamentoId = 73,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 836,
                    Nombre = "San Luís",
                    DepartamentoId = 5,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 837,
                    Nombre = "San Luís de Gaceno",
                    DepartamentoId = 15,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 838,
                    Nombre = "San Luís de Palenque",
                    DepartamentoId = 85,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 839,
                    Nombre = "San Marcos",
                    DepartamentoId = 70,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 840,
                    Nombre = "San Martín",
                    DepartamentoId = 20,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 841,
                    Nombre = "San Martín",
                    DepartamentoId = 50,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 842,
                    Nombre = "San Martín de Loba",
                    DepartamentoId = 13,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 843,
                    Nombre = "San Mateo",
                    DepartamentoId = 15,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 844,
                    Nombre = "San Miguel",
                    DepartamentoId = 68,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 845,
                    Nombre = "San Miguel",
                    DepartamentoId = 86,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 846,
                    Nombre = "San Miguel de Sema",
                    DepartamentoId = 15,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 847,
                    Nombre = "San Onofre",
                    DepartamentoId = 70,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 848,
                    Nombre = "San Pablo",
                    DepartamentoId = 13,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 849,
                    Nombre = "San Pablo",
                    DepartamentoId = 52,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 850,
                    Nombre = "San Pablo de Borbur",
                    DepartamentoId = 15,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 851,
                    Nombre = "San Pedro",
                    DepartamentoId = 5,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 852,
                    Nombre = "San Pedro",
                    DepartamentoId = 70,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 853,
                    Nombre = "San Pedro",
                    DepartamentoId = 76,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 854,
                    Nombre = "San Pedro de Cartago",
                    DepartamentoId = 52,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 855,
                    Nombre = "San Pedro de Urabá",
                    DepartamentoId = 5,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 856,
                    Nombre = "San Pelayo",
                    DepartamentoId = 23,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 857,
                    Nombre = "San Rafael",
                    DepartamentoId = 5,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 858,
                    Nombre = "San Roque",
                    DepartamentoId = 5,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 859,
                    Nombre = "San Sebastián",
                    DepartamentoId = 19,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 860,
                    Nombre = "San Sebastián de Buenavista",
                    DepartamentoId = 47,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 861,
                    Nombre = "San Vicente",
                    DepartamentoId = 5,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 862,
                    Nombre = "San Vicente del Caguán",
                    DepartamentoId = 18,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 863,
                    Nombre = "San Vicente del Chucurí",
                    DepartamentoId = 68,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 864,
                    Nombre = "San Zenón",
                    DepartamentoId = 47,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 865,
                    Nombre = "Sandoná",
                    DepartamentoId = 52,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 866,
                    Nombre = "Santa Ana",
                    DepartamentoId = 47,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 867,
                    Nombre = "Santa Bárbara",
                    DepartamentoId = 5,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 868,
                    Nombre = "Santa Bárbara",
                    DepartamentoId = 68,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 869,
                    Nombre = "Santa Bárbara (Iscuandé)",
                    DepartamentoId = 52,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 870,
                    Nombre = "Santa Bárbara de Pinto",
                    DepartamentoId = 47,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 871,
                    Nombre = "Santa Catalina",
                    DepartamentoId = 13,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 872,
                    Nombre = "Santa Fé de Antioquia",
                    DepartamentoId = 5,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 873,
                    Nombre = "Santa Genoveva de Docorodó",
                    DepartamentoId = 27,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 874,
                    Nombre = "Santa Helena del Opón",
                    DepartamentoId = 68,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 875,
                    Nombre = "Santa Isabel",
                    DepartamentoId = 73,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 876,
                    Nombre = "Santa Lucía",
                    DepartamentoId = 8,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 877,
                    Nombre = "Santa Marta",
                    DepartamentoId = 47,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 878,
                    Nombre = "Santa María",
                    DepartamentoId = 15,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 879,
                    Nombre = "Santa María",
                    DepartamentoId = 41,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 880,
                    Nombre = "Santa Rosa",
                    DepartamentoId = 13,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 881,
                    Nombre = "Santa Rosa",
                    DepartamentoId = 19,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 882,
                    Nombre = "Santa Rosa de Cabal",
                    DepartamentoId = 66,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 883,
                    Nombre = "Santa Rosa de Osos",
                    DepartamentoId = 5,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 884,
                    Nombre = "Santa Rosa de Viterbo",
                    DepartamentoId = 15,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 885,
                    Nombre = "Santa Rosa del Sur",
                    DepartamentoId = 13,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 886,
                    Nombre = "Santa Rosalía",
                    DepartamentoId = 99,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 887,
                    Nombre = "Santa Sofía",
                    DepartamentoId = 15,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 888,
                    Nombre = "Santana",
                    DepartamentoId = 15,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 889,
                    Nombre = "Santander de Quilichao",
                    DepartamentoId = 19,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 890,
                    Nombre = "Santiago",
                    DepartamentoId = 54,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 891,
                    Nombre = "Santiago",
                    DepartamentoId = 86,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 892,
                    Nombre = "Santo Domingo",
                    DepartamentoId = 5,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 893,
                    Nombre = "Santo Tomás",
                    DepartamentoId = 8,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 894,
                    Nombre = "Santuario",
                    DepartamentoId = 5,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 895,
                    Nombre = "Santuario",
                    DepartamentoId = 66,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 896,
                    Nombre = "Sapuyes",
                    DepartamentoId = 52,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 897,
                    Nombre = "Saravena",
                    DepartamentoId = 81,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 898,
                    Nombre = "Sardinata",
                    DepartamentoId = 54,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 899,
                    Nombre = "Sasaima",
                    DepartamentoId = 25,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 900,
                    Nombre = "Sativanorte",
                    DepartamentoId = 15,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 901,
                    Nombre = "Sativasur",
                    DepartamentoId = 15,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 902,
                    Nombre = "Segovia",
                    DepartamentoId = 5,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 903,
                    Nombre = "Sesquilé",
                    DepartamentoId = 25,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 904,
                    Nombre = "Sevilla",
                    DepartamentoId = 76,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 905,
                    Nombre = "Siachoque",
                    DepartamentoId = 15,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 906,
                    Nombre = "Sibaté",
                    DepartamentoId = 25,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 907,
                    Nombre = "Sibundoy",
                    DepartamentoId = 86,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 908,
                    Nombre = "Silos",
                    DepartamentoId = 54,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 909,
                    Nombre = "Silvania",
                    DepartamentoId = 25,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 910,
                    Nombre = "Silvia",
                    DepartamentoId = 19,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 911,
                    Nombre = "Simacota",
                    DepartamentoId = 68,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 912,
                    Nombre = "Simijaca",
                    DepartamentoId = 25,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 913,
                    Nombre = "Simití",
                    DepartamentoId = 13,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 914,
                    Nombre = "Sincelejo",
                    DepartamentoId = 70,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 915,
                    Nombre = "Sincé",
                    DepartamentoId = 70,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 916,
                    Nombre = "Sipí",
                    DepartamentoId = 27,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 917,
                    Nombre = "Sitionuevo",
                    DepartamentoId = 47,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 918,
                    Nombre = "Soacha",
                    DepartamentoId = 25,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 919,
                    Nombre = "Soatá",
                    DepartamentoId = 15,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 920,
                    Nombre = "Socha",
                    DepartamentoId = 15,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 921,
                    Nombre = "Socorro",
                    DepartamentoId = 68,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 922,
                    Nombre = "Socotá",
                    DepartamentoId = 15,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 923,
                    Nombre = "Sogamoso",
                    DepartamentoId = 15,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 924,
                    Nombre = "Solano",
                    DepartamentoId = 18,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 925,
                    Nombre = "Soledad",
                    DepartamentoId = 8,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 926,
                    Nombre = "Solita",
                    DepartamentoId = 18,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 927,
                    Nombre = "Somondoco",
                    DepartamentoId = 15,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 928,
                    Nombre = "Sonsón",
                    DepartamentoId = 5,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 929,
                    Nombre = "Sopetrán",
                    DepartamentoId = 5,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 930,
                    Nombre = "Soplaviento",
                    DepartamentoId = 13,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 931,
                    Nombre = "Sopó",
                    DepartamentoId = 25,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 932,
                    Nombre = "Sora",
                    DepartamentoId = 15,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 933,
                    Nombre = "Soracá",
                    DepartamentoId = 15,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 934,
                    Nombre = "Sotaquirá",
                    DepartamentoId = 15,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 935,
                    Nombre = "Sotara (Paispamba)",
                    DepartamentoId = 19,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 936,
                    Nombre = "Sotomayor (Los Andes)",
                    DepartamentoId = 52,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 937,
                    Nombre = "Suaita",
                    DepartamentoId = 68,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 938,
                    Nombre = "Suan",
                    DepartamentoId = 8,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 939,
                    Nombre = "Suaza",
                    DepartamentoId = 41,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 940,
                    Nombre = "Subachoque",
                    DepartamentoId = 25,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 941,
                    Nombre = "Sucre",
                    DepartamentoId = 19,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 942,
                    Nombre = "Sucre",
                    DepartamentoId = 68,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 943,
                    Nombre = "Sucre",
                    DepartamentoId = 70,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 944,
                    Nombre = "Suesca",
                    DepartamentoId = 25,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 945,
                    Nombre = "Supatá",
                    DepartamentoId = 25,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 946,
                    Nombre = "Supía",
                    DepartamentoId = 17,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 947,
                    Nombre = "Suratá",
                    DepartamentoId = 68,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 948,
                    Nombre = "Susa",
                    DepartamentoId = 25,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 949,
                    Nombre = "Susacón",
                    DepartamentoId = 15,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 950,
                    Nombre = "Sutamarchán",
                    DepartamentoId = 15,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 951,
                    Nombre = "Sutatausa",
                    DepartamentoId = 25,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 952,
                    Nombre = "Sutatenza",
                    DepartamentoId = 15,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 953,
                    Nombre = "Suárez",
                    DepartamentoId = 19,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 954,
                    Nombre = "Suárez",
                    DepartamentoId = 73,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 955,
                    Nombre = "Sácama",
                    DepartamentoId = 85,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 956,
                    Nombre = "Sáchica",
                    DepartamentoId = 15,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 957,
                    Nombre = "Tabio",
                    DepartamentoId = 25,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 958,
                    Nombre = "Tadó",
                    DepartamentoId = 27,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 959,
                    Nombre = "Talaigua Nuevo",
                    DepartamentoId = 13,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 960,
                    Nombre = "Tamalameque",
                    DepartamentoId = 20,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 961,
                    Nombre = "Tame",
                    DepartamentoId = 81,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 962,
                    Nombre = "Taminango",
                    DepartamentoId = 52,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 963,
                    Nombre = "Tangua",
                    DepartamentoId = 52,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 964,
                    Nombre = "Taraira",
                    DepartamentoId = 97,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 965,
                    Nombre = "Tarazá",
                    DepartamentoId = 5,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 966,
                    Nombre = "Tarqui",
                    DepartamentoId = 41,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 967,
                    Nombre = "Tarso",
                    DepartamentoId = 5,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 968,
                    Nombre = "Tasco",
                    DepartamentoId = 15,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 969,
                    Nombre = "Tauramena",
                    DepartamentoId = 85,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 970,
                    Nombre = "Tausa",
                    DepartamentoId = 25,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 971,
                    Nombre = "Tello",
                    DepartamentoId = 41,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 972,
                    Nombre = "Tena",
                    DepartamentoId = 25,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 973,
                    Nombre = "Tenerife",
                    DepartamentoId = 47,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 974,
                    Nombre = "Tenjo",
                    DepartamentoId = 25,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 975,
                    Nombre = "Tenza",
                    DepartamentoId = 15,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 976,
                    Nombre = "Teorama",
                    DepartamentoId = 54,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 977,
                    Nombre = "Teruel",
                    DepartamentoId = 41,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 978,
                    Nombre = "Tesalia",
                    DepartamentoId = 41,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 979,
                    Nombre = "Tibacuy",
                    DepartamentoId = 25,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 980,
                    Nombre = "Tibaná",
                    DepartamentoId = 15,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 981,
                    Nombre = "Tibasosa",
                    DepartamentoId = 15,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 982,
                    Nombre = "Tibirita",
                    DepartamentoId = 25,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 983,
                    Nombre = "Tibú",
                    DepartamentoId = 54,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 984,
                    Nombre = "Tierralta",
                    DepartamentoId = 23,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 985,
                    Nombre = "Timaná",
                    DepartamentoId = 41,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 986,
                    Nombre = "Timbiquí",
                    DepartamentoId = 19,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 987,
                    Nombre = "Timbío",
                    DepartamentoId = 19,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 988,
                    Nombre = "Tinjacá",
                    DepartamentoId = 15,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 989,
                    Nombre = "Tipacoque",
                    DepartamentoId = 15,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 990,
                    Nombre = "Tiquisio (Puerto Rico)",
                    DepartamentoId = 13,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 991,
                    Nombre = "Titiribí",
                    DepartamentoId = 5,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 992,
                    Nombre = "Toca",
                    DepartamentoId = 15,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 993,
                    Nombre = "Tocaima",
                    DepartamentoId = 25,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 994,
                    Nombre = "Tocancipá",
                    DepartamentoId = 25,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 995,
                    Nombre = "Toguí",
                    DepartamentoId = 15,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 996,
                    Nombre = "Toledo",
                    DepartamentoId = 5,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 997,
                    Nombre = "Toledo",
                    DepartamentoId = 54,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 998,
                    Nombre = "Tolú",
                    DepartamentoId = 70,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 999,
                    Nombre = "Tolú Viejo",
                    DepartamentoId = 70,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 1000,
                    Nombre = "Tona",
                    DepartamentoId = 68,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 1001,
                    Nombre = "Topagá",
                    DepartamentoId = 15,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 1002,
                    Nombre = "Topaipí",
                    DepartamentoId = 25,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 1003,
                    Nombre = "Toribío",
                    DepartamentoId = 19,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 1004,
                    Nombre = "Toro",
                    DepartamentoId = 76,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 1005,
                    Nombre = "Tota",
                    DepartamentoId = 15,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 1006,
                    Nombre = "Totoró",
                    DepartamentoId = 19,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 1007,
                    Nombre = "Trinidad",
                    DepartamentoId = 85,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 1008,
                    Nombre = "Trujillo",
                    DepartamentoId = 76,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 1009,
                    Nombre = "Tubará",
                    DepartamentoId = 8,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 1010,
                    Nombre = "Tuchín",
                    DepartamentoId = 23,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 1011,
                    Nombre = "Tulúa",
                    DepartamentoId = 76,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 1012,
                    Nombre = "Tumaco",
                    DepartamentoId = 52,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 1013,
                    Nombre = "Tunja",
                    DepartamentoId = 15,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 1014,
                    Nombre = "Tunungua",
                    DepartamentoId = 15,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 1015,
                    Nombre = "Turbaco",
                    DepartamentoId = 13,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 1016,
                    Nombre = "Turbaná",
                    DepartamentoId = 13,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 1017,
                    Nombre = "Turbo",
                    DepartamentoId = 5,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 1018,
                    Nombre = "Turmequé",
                    DepartamentoId = 15,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 1019,
                    Nombre = "Tuta",
                    DepartamentoId = 15,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 1020,
                    Nombre = "Tutasá",
                    DepartamentoId = 15,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 1021,
                    Nombre = "Támara",
                    DepartamentoId = 85,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 1022,
                    Nombre = "Támesis",
                    DepartamentoId = 5,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 1023,
                    Nombre = "Túquerres",
                    DepartamentoId = 52,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 1024,
                    Nombre = "Ubalá",
                    DepartamentoId = 25,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 1025,
                    Nombre = "Ubaque",
                    DepartamentoId = 25,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 1026,
                    Nombre = "Ubaté",
                    DepartamentoId = 25,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 1027,
                    Nombre = "Ulloa",
                    DepartamentoId = 76,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 1028,
                    Nombre = "Une",
                    DepartamentoId = 25,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 1029,
                    Nombre = "Unguía",
                    DepartamentoId = 27,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 1030,
                    Nombre = "Unión Panamericana (Ã?NIMAS)",
                    DepartamentoId = 27,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 1031,
                    Nombre = "Uramita",
                    DepartamentoId = 5,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 1032,
                    Nombre = "Uribe",
                    DepartamentoId = 50,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 1033,
                    Nombre = "Uribia",
                    DepartamentoId = 44,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 1034,
                    Nombre = "Urrao",
                    DepartamentoId = 5,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 1035,
                    Nombre = "Urumita",
                    DepartamentoId = 44,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 1036,
                    Nombre = "Usiacuri",
                    DepartamentoId = 8,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 1037,
                    Nombre = "Valdivia",
                    DepartamentoId = 5,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 1038,
                    Nombre = "Valencia",
                    DepartamentoId = 23,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 1039,
                    Nombre = "Valle de San José",
                    DepartamentoId = 68,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 1040,
                    Nombre = "Valle de San Juan",
                    DepartamentoId = 73,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 1041,
                    Nombre = "Valle del Guamuez",
                    DepartamentoId = 86,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 1042,
                    Nombre = "Valledupar",
                    DepartamentoId = 20,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 1043,
                    Nombre = "Valparaiso",
                    DepartamentoId = 5,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 1044,
                    Nombre = "Valparaiso",
                    DepartamentoId = 18,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 1045,
                    Nombre = "Vegachí",
                    DepartamentoId = 5,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 1046,
                    Nombre = "Venadillo",
                    DepartamentoId = 73,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 1047,
                    Nombre = "Venecia",
                    DepartamentoId = 5,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 1048,
                    Nombre = "Venecia (Ospina Pérez)",
                    DepartamentoId = 25,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 1049,
                    Nombre = "Ventaquemada",
                    DepartamentoId = 15,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 1050,
                    Nombre = "Vergara",
                    DepartamentoId = 25,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 1051,
                    Nombre = "Versalles",
                    DepartamentoId = 76,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 1052,
                    Nombre = "Vetas",
                    DepartamentoId = 68,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 1053,
                    Nombre = "Viani",
                    DepartamentoId = 25,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 1054,
                    Nombre = "Vigía del Fuerte",
                    DepartamentoId = 5,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 1055,
                    Nombre = "Vijes",
                    DepartamentoId = 76,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 1056,
                    Nombre = "Villa Caro",
                    DepartamentoId = 54,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 1057,
                    Nombre = "Villa Rica",
                    DepartamentoId = 19,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 1058,
                    Nombre = "Villa de Leiva",
                    DepartamentoId = 15,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 1059,
                    Nombre = "Villa del Rosario",
                    DepartamentoId = 54,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 1060,
                    Nombre = "Villagarzón",
                    DepartamentoId = 86,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 1061,
                    Nombre = "Villagómez",
                    DepartamentoId = 25,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 1062,
                    Nombre = "Villahermosa",
                    DepartamentoId = 73,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 1063,
                    Nombre = "Villamaría",
                    DepartamentoId = 17,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 1064,
                    Nombre = "Villanueva",
                    DepartamentoId = 13,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 1065,
                    Nombre = "Villanueva",
                    DepartamentoId = 44,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 1066,
                    Nombre = "Villanueva",
                    DepartamentoId = 68,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 1067,
                    Nombre = "Villanueva",
                    DepartamentoId = 85,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 1068,
                    Nombre = "Villapinzón",
                    DepartamentoId = 25,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 1069,
                    Nombre = "Villarrica",
                    DepartamentoId = 73,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 1070,
                    Nombre = "Villavicencio",
                    DepartamentoId = 50,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 1071,
                    Nombre = "Villavieja",
                    DepartamentoId = 41,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 1072,
                    Nombre = "Villeta",
                    DepartamentoId = 25,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 1073,
                    Nombre = "Viotá",
                    DepartamentoId = 25,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 1074,
                    Nombre = "Viracachá",
                    DepartamentoId = 15,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 1075,
                    Nombre = "Vista Hermosa",
                    DepartamentoId = 50,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 1076,
                    Nombre = "Viterbo",
                    DepartamentoId = 17,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 1077,
                    Nombre = "Vélez",
                    DepartamentoId = 68,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 1078,
                    Nombre = "Yacopí",
                    DepartamentoId = 25,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 1079,
                    Nombre = "Yacuanquer",
                    DepartamentoId = 52,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 1080,
                    Nombre = "Yaguará",
                    DepartamentoId = 41,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 1081,
                    Nombre = "Yalí",
                    DepartamentoId = 5,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 1082,
                    Nombre = "Yarumal",
                    DepartamentoId = 5,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 1083,
                    Nombre = "Yolombó",
                    DepartamentoId = 5,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 1084,
                    Nombre = "Yondó (Casabe)",
                    DepartamentoId = 5,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 1085,
                    Nombre = "Yopal",
                    DepartamentoId = 85,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 1086,
                    Nombre = "Yotoco",
                    DepartamentoId = 76,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 1087,
                    Nombre = "Yumbo",
                    DepartamentoId = 76,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 1088,
                    Nombre = "Zambrano",
                    DepartamentoId = 13,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 1089,
                    Nombre = "Zapatoca",
                    DepartamentoId = 68,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 1090,
                    Nombre = "Zapayán (PUNTA DE PIEDRAS)",
                    DepartamentoId = 47,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 1091,
                    Nombre = "Zaragoza",
                    DepartamentoId = 5,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 1092,
                    Nombre = "Zarzal",
                    DepartamentoId = 76,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 1093,
                    Nombre = "Zetaquirá",
                    DepartamentoId = 15,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 1094,
                    Nombre = "Zipacón",
                    DepartamentoId = 25,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 1095,
                    Nombre = "Zipaquirá",
                    DepartamentoId = 25,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 1096,
                    Nombre = "Zona Bananera (PRADO  SEVILLA)",
                    DepartamentoId = 47,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 1097,
                    Nombre = "Ábrego",
                    DepartamentoId = 54,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 1098,
                    Nombre = "Íquira",
                    DepartamentoId = 41,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 1099,
                    Nombre = "Úmbita",
                    DepartamentoId = 15,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                },
                new Municipio
                {
                    MunicipioId = 1100,
                    Nombre = "Útica",
                    DepartamentoId = 25,

                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                }
            );

            #endregion

            modelBuilder.Entity<User>().HasData(
                new User()
                {
                    UserId = 1,
                    Username = "Juan",
                    Password = "123456",
                    CreatedAt = _cratedAt,
                    CreatedBy = _cratedBy
                }
            );
        }
        public static void SeedPersona(this ModelBuilder modelBuilder)
        {
            var id = 1;
            var fecha = new DateTime(1994, 9, 14);
            var random = new Random();

            var faker = new Bogus.Faker<Persona>()
                .RuleFor(x => x.PersonaID, f => id++)
                .RuleFor(x => x.NombreCompleto, f => f.Person.FullName)
                .RuleFor(x => x.Direccion, f => f.Address.StreetAddress(true))
                .RuleFor(x => x.Telefono, f => f.Phone.PhoneNumber())
                .RuleFor(x => x.Nacimiento, f => fecha.AddDays(random.Next(1,10000)))
                .RuleFor(x => x.MunicipioID, f => random.Next(1,1100))
                ;

            foreach (var p in faker.Generate(500))
                modelBuilder.Entity<Persona>().HasData(p);
        }
    }
}

using EmpregoInfo.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmpregoInfo.Data
{
    /// <summary>
    /// Representa a DB do nosso sistema (EmpregoInfo)
    /// À custa de um ORM (Mapeador de objectos relacionais)
    /// </summary>
    public class EmpregoDB : DbContext{
        public EmpregoDB(DbContextOptions<EmpregoDB> options) : base(options) { }

        // ativação do Lazy Loading
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
           optionsBuilder.UseLazyLoadingProxies();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            base.OnModelCreating(modelBuilder);



            modelBuilder.Entity<Utilizadores>().HasData(
                new Utilizadores { ID = 1, Nome = "Luís Freitas", Telefone = "910982783", Cidade = "Ourém", DescricaoDoPerfilUtilizador = "Muito trabalhador", Foto = "1_LuisFreitas.jpg", CurriculoUtilizador = "1_LuisFreitas.pdf", DataDeNascimento = new DateTime(1990, 4, 14).Date, Data_criacao_conta = new DateTime(2020, 3, 12).Date },
                new Utilizadores { ID = 2, Nome = "Carlos Magno", Telefone = "931243233", Cidade = "Lisboa", DescricaoDoPerfilUtilizador = "Muito Efeciente", Foto = "2_CarlosMagno.jpg", CurriculoUtilizador = "2_CarlosMagno.pdf", DataDeNascimento = new DateTime(1981, 12, 3).Date, Data_criacao_conta = new DateTime(2020, 4, 1).Date },
                new Utilizadores { ID = 3, Nome = "Hamilton Ferrão", Telefone = "962436835", Cidade = "Loures", DescricaoDoPerfilUtilizador = "Iniciativa própria. Não esperar que as coisas aconteçam.", Foto = "3_HamiltonFerrão.jpg", CurriculoUtilizador = "3_HamiltonFerrão.pdf", DataDeNascimento = new DateTime(1974, 9, 22).Date, Data_criacao_conta = new DateTime(2020, 2, 3).Date },
                new Utilizadores { ID = 4, Nome = "Vasco André", Telefone = "915788432", Cidade = "Abrantes", DescricaoDoPerfilUtilizador = "Criativo e encontro novos métodos de trabalho que possam melhorar ainda mais o dinamismo da empresa.", Foto = "4_VascoAndré.jpg", CurriculoUtilizador = "4_VascoAndré.pdf", DataDeNascimento = new DateTime(1994, 4, 23).Date, Data_criacao_conta = new DateTime(2020, 2, 3).Date },
                new Utilizadores { ID = 5, Nome = "Filipe Luís", Telefone = "923777649", Cidade = "Encontramento", DescricaoDoPerfilUtilizador = "Diante das perspectivas das sociedades modernas o eu sou otimista para acreditar na minha capacidade.", Foto = "5_FilipeLuís.jpg", CurriculoUtilizador = "5_FilipeLuís.pdf", DataDeNascimento = new DateTime(1982, 11, 3).Date, Data_criacao_conta = new DateTime(2020, 3, 19).Date },
                new Utilizadores { ID = 6, Nome = "António Amaro", Telefone = "917893678", Cidade = "Lisboa", DescricaoDoPerfilUtilizador = "Designer. Produtos da Adobe", Foto = "6_AntónioAmaro.jpg", CurriculoUtilizador = "6_AntónioAmaro.pdf", DataDeNascimento = new DateTime(1990, 7, 3).Date, Data_criacao_conta = new DateTime(2020, 4, 12).Date }
            );
        

            modelBuilder.Entity<Empresas>().HasData(
                new Empresas { ID = 1, Nome = "Engenharia Software", Morada = "Rua Isidoro Inácio Alves de Carvalho Nº1", CodigoPostal = "2500-321 CALDAS DA RAINHA", NIF = "239221452", Atividade = "Gestão de Serviços", WebSite = "www.engenhariasoftware.pt", Email = "geral@engsoftware.pt", Telefone = "262311683", Logotipo = "1_EngenhariaSoftware.jpg" },
                new Empresas { ID = 2, Nome = "Data Soft", Morada = "Rua Mario de Oliveira Nº7", CodigoPostal = "3230-320 Penela", NIF = "213999723", Atividade = "Serviços de Outsourcing", WebSite = "www.datasoft.pt", Email = "geral@engsoftware.pt", Telefone = "213997123", Logotipo = "2_DataSoft.jpg" },
                new Empresas { ID = 3, Nome = "AWQ Software", Morada = "Rua Manual Alves Ribeiro Nº19", CodigoPostal = "2344-191 Ourém", NIF = "253384131", Atividade = "Serviços de Outsourcing", WebSite = "www.engenhariasoftware.pt", Email = "geral@awqsoftware.pt", Telefone = "276293721", Logotipo = "3_awqsoftware.jpg" }
            );

            modelBuilder.Entity<Anuncios>().HasData(
                new Anuncios { ID = 1, Tipo = "Full-Time", Titulo = "Técnico de Linux", Descricao = "Procuramos um técnico versatil e com experiência comprovada. Tecnologias = Linux, Vmware", ExperienciaNecessaria = "Mínimo de 2 anos de experiência", Local = "Lisboa, Parque das Nações", Salario = "25.000€ Anual Brutos", DataCriacaoAnuncio = new DateTime(2020, 4, 2), EmpresaFK = 2 },
                new Anuncios { ID = 2, Tipo = "Full-Time", Titulo = "Programador WEB - Junior", Descricao = "Requisitos Experiência mínima de 5 anos em funções de desenvolvimento para a Web, em plataformas que envolvam:PHP, Postgres, Redis, GitLab.", ExperienciaNecessaria = "Mínimo de 1 anos", Local = "Matosinhos, Porto", Salario = "40.000€ Anual Brutos", DataCriacaoAnuncio = new DateTime(2020, 2, 4), EmpresaFK = 2 },
                new Anuncios { ID = 3, Tipo = "Full-Time", Titulo = "Product/UX Designer at PHC", Descricao = "Experiência profissional mínima de 3 anos em product design ou service design", ExperienciaNecessaria = "Experiência profissional mínima de 3 anos em product design ou service design", Local = "Oeiras", Salario = "1300€ LiquidoMês", DataCriacaoAnuncio = new DateTime(2020, 2, 7), EmpresaFK = 1 },
                new Anuncios { ID = 4, Tipo = "Full-Time", Titulo = "Assistentes Suporte Técnico", Descricao = "12º Ano de escolaridade, Conhecimentos técnicos sobre redes, telecomunicações e informática (Preferencial).", ExperienciaNecessaria = "Sem experiência necessária", Local = "Lisboa, Gare do Oriente", Salario = "1000€ Brutos Mês", DataCriacaoAnuncio = new DateTime(2020, 3, 4), EmpresaFK = 1 },
                new Anuncios { ID = 5, Tipo = "Full-Time", Titulo = "Java Team Lead", Descricao = "Engenharia Informática", ExperienciaNecessaria = "Experiencia em Java, HYML, CSS, jQuery e Ajax. Conhecimentos em Swing e JDF. Webservices: API Rest, SOAP (XML, JSON). Excelente dominio do francês.", Local = "Lisboa, Gare do Oriente", Salario = "3000€ Brutos Mês", DataCriacaoAnuncio = new DateTime(2020, 3, 4), EmpresaFK = 2 },
                new Anuncios { ID = 6, Tipo = "Full-Time", Titulo = "Service Desk Agent - Holandês", Descricao = "12º ou Licenciatura em Informática;", ExperienciaNecessaria = "Experiência em aplicações ou gestão de data center. Fluência em Holandês.", Local = "Lisboa", Salario = "1000 Brutos Mês", DataCriacaoAnuncio = new DateTime(2020, 4, 2), EmpresaFK = 2 }
            );


        }
        // adicionar as 'tabelas' à Base de Dados

        public DbSet<Utilizadores> Utilizadores { get; set; }
        public DbSet<Empresas> Empresas { get; set; }
        public DbSet<Anuncios> Anuncios { get; set; }
        public DbSet<Candidaturas> Candidaturas { get; set; }
    }
}

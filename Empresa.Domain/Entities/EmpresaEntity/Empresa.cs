using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Empresa.Domain.Entities
{
    public class Empresa
    {
        #region PROPRIEDADES
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Column(TypeName = "varchar(80)")]
        public string Cnpj { get; set; }

        [Column(TypeName = "varchar(80)")]
        public string NomeEmpresarial { get; set; }

        [Column(TypeName = "varchar(80)")]
        public string NomeFantasia { get; set; }

        [Column(TypeName = "varchar(80)")]
        public string Porte { get; set; }

        [Column(TypeName = "varchar(80)")]
        public string Logradouro { get; set; }

        [Column(TypeName = "varchar(80)")]
        public string Numero { get; set; }

        [Column(TypeName = "varchar(80)")]
        public string Complemento { get; set; }

        [Column(TypeName = "varchar(80)")]
        public string Cep { get; set; }

        [Column(TypeName = "varchar(80)")]
        public string Bairro { get; set; }

        [Column(TypeName = "varchar(80)")]
        public string Municipio { get; set; }


        public string Uf { get; set; }

        [Column(TypeName = "varchar(80)")]
        public string Email { get; set; }

        [Column(TypeName = "varchar(80)")]
        public string Telefone { get; set; }

        [Column(TypeName = "varchar(80)")]
        public string SituacaoCadastral { get; set; }
        #endregion

        public Empresa(string cnpj)
        {
            if (ValidaCnpj(cnpj) == true)
            {
                Cnpj = cnpj;
            }
            else
                throw new Exception("Cnpj inválido.");
        }

        public bool ValidaCnpj(string cnpj)
        {
            int[] multiplicador1 = new int[12] { 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicador2 = new int[13] { 6, 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };

            cnpj = cnpj.Trim().Replace(".", "").Replace("-", "").Replace("/", "");

            if (cnpj.Length != 14)
            {
                return false;
            }
            else
            {
                string cnpjAuxiliar = cnpj.Substring(0, 12);
                int somatorio = 0;

                for (int i = 0; i < 12; i++)
                    somatorio += int.Parse(cnpjAuxiliar[i].ToString()) * multiplicador1[i];

                int resto = somatorio % 11;

                if (resto < 2)
                    resto = 0;
                else
                    resto = 11 - resto;

                string digitoVerificador = resto.ToString();

                cnpjAuxiliar = cnpjAuxiliar + digitoVerificador;
                somatorio = 0;

                for (int i = 0; i < 13; i++)
                    somatorio += int.Parse(cnpjAuxiliar[i].ToString()) * multiplicador2[i];

                resto = somatorio % 11;
                if (resto < 2)
                    resto = 0;
                else
                    resto = 11 - resto;
                digitoVerificador = digitoVerificador + resto.ToString();

                return cnpj.EndsWith(digitoVerificador);
            }
        }
    }
}

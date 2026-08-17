using SQLitePCL;
using System;
using System.Collections.Generic;
using System.Text;
namespace MauiAppMinhasCompras.Models
{
    public class Produto
    {
      
        public int Id { get; set; }
        public string Descricao { get; set; }
        public double Quantidade { get; set; }
        public double Preco { get; set; }
    }
}
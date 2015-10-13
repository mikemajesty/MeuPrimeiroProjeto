
namespace Model
{
    public class Vendas
    {
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        private double valorTotal;

        public double ValorTotal
        {
            get { return valorTotal; }
            set { valorTotal = value; }
        }
        private double valorLucro;

        public double ValorLucro
        {
            get { return valorLucro; }
            set { valorLucro = value; }
        }
        private string data;

        public string Data
        {
            get { return data; }
            set { data = value; }
        }

        private double valorAdd;

        public double ValorAdd
        {
            get { return ValorAdd; }
            set { ValorAdd = value; }

        }
        
    }
}

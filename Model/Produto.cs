
namespace Model
{
    public class Produto
    {
        private int idProduto;

        public int IdProduto
        {
            get { return idProduto; }
            set { idProduto = value; }
        }
        private string nome;

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        private string categoria;

        public string Categoria
        {
            get { return categoria; }
            set { categoria = value; }
        }
        private string tipo;

        public string Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }

        private double precoCompra;

        public double PrecoCompra
        {
            get { return precoCompra; }
            set { precoCompra = value; }
        }
        private double precoVenda;

        public double PrecoVenda
        {
            get { return precoVenda; }
            set { precoVenda = value; }
        }
        private string marca;

        public string Marca
        {
            get { return marca; }
            set { marca = value; }
        }
        private int qtdEstoque;

        public int QtdEstoque
        {
            get { return qtdEstoque; }
            set { qtdEstoque = value; }
        }
        
        
     
        
    }
}

namespace Banco3
{
    public class CPF : IDocumento
    {
        public string cpf { get;private set; }
        public CPF()
        {

        }
        public CPF(string documento)
        {
            this.cpf = documento;
        }
        public bool ehValida()
        {
            return true;
        }

        public override string ToString()
        {
            return this.cpf;
        }

        public override bool Equals(object obj)
        {
            CPF documento = (CPF)obj;
            return this.cpf.Equals(documento.cpf);
        }
    }
}
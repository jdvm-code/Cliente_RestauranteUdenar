namespace RestauranteUdenar.Auxiliares
{
    public class ComboComidaItem
    {
        public int Id { get; set; }
        public string Texto { get; set; }

        public override string ToString()
        {
            return Texto;
        }
    }

    
}
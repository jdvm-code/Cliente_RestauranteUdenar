namespace RestauranteUdenar.Auxiliares
{
    public class ComboHorarioItem
    {
        public int Id { get; set; }
        public string Texto { get; set; }

        public override string ToString()
        {
            return Texto;
        }
    }

    
}
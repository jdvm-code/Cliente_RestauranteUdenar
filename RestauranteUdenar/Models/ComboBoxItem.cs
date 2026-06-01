namespace RestauranteUdenar.Models
{
    public class ComboBoxItem
    {
        public string Display { get; set; }   // "11:30:00 - 12:15:00"
        public int Value { get; set; }          // id del horario

        public override string ToString()
        {
            return Display; // Esto es lo que se muestra en el ComboBox
        }
    }
}
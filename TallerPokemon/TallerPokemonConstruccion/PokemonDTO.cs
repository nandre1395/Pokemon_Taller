namespace TallerPokemon;

class PokemonDTO
{
    public int Id { get; set; }
    public string Nombre { get; set; }
    public string Tipo { get; set; }
    public double Defensa { get; set; }
    public List<int> Habilidades { get; set; }
}


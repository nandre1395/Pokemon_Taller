namespace TallerPokemon;

interface IPokemon
{
    public void CrearPoke(PokemonDTO pokemon);

    public void CrearVariosPoke(PokemonDTO[] pokemones);

    public void EditarPoke(int Id, PokemonDTO pokemon);

    public void EliminarPoke(int Id);

    public PokemonDTO MostrarPoke(int Id);

    public List<PokemonDTO> MostrarPorTipo(string Tipo);
}
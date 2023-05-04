using TallerPokemon;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

Pokemones objetoP = new Pokemones();

app.MapPost("/api/v1/pokemon/crearunpoke", (PokemonDTO pokemon) =>
{
    objetoP.CrearPoke(pokemon);
    return Results.Ok("Pokemon agregado exitosamente..!");

});

app.MapPost("/api/v1/pokemon/crearmuchospoke", (PokemonDTO[] pokemones) =>
 {
     foreach (var poke in pokemones)
     {
         objetoP.CrearVariosPoke(pokemones);


     }

 });

app.MapPut("/api/v1/pokemon/actualizarpoke/{Id}", (PokemonDTO pokemon, int Id) =>
{
    objetoP.EditarPoke(Id, pokemon);
    return Results.Ok("Se a actualizado tu pokemon");
});

app.MapDelete("/api/v1/pokemon/eliminarpoke/{Id}", (int Id) =>
{
    objetoP.EliminarPoke(Id);
    return Results.Ok("Se a eliminado tu pokemon");
});


app.MapGet("/api/v1/pokemon/mostrarunpoke/{id}", (int Id) =>
{
    return Results.Ok(objetoP.MostrarPoke(Id));
});

app.MapGet("/api/v1/pokemon/mostrarpokeportipo/{Tipo}", (string Tipo) =>
{
    return Results.Ok(objetoP.MostrarPorTipo(Tipo));
});

app.Run();

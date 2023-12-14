var builder = WebApplication.CreateBuilder(args);
builder.Services.AddEndpointsApiExplorer();


var app = builder.Build();
/*if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}*/
app.UseHttpsRedirection();

var choices = new[]
{
    "Schere", "Stein", "Papier", "Echse", "Spock"
};

app.MapGet("/playgame/{username}/{choice}", context =>
{
Random random = new Random();
string computerChoice = choices[random.Next(0, 5)];
var playerChoiceContext = context.GetRouteValue("choice");
var username = context.GetRouteValue("username");
    string playerChoice = (string) playerChoiceContext;
    
        if ((playerChoice == "schere" && (computerChoice.ToLower() == "Papier".ToLower() || computerChoice.ToLower() == "Echse".ToLower())) ||
            (playerChoice == "papier" && (computerChoice.ToLower() == "Stein".ToLower() || computerChoice.ToLower() == "Spock".ToLower())) ||
            (playerChoice == "stein" && (computerChoice.ToLower() == "Echse".ToLower() || computerChoice.ToLower() == "Schere".ToLower())) ||
            (playerChoice == "echse" && (computerChoice.ToLower() == "Spock".ToLower() || computerChoice.ToLower() == "Papier".ToLower())) ||
            (playerChoice == "spock" && (computerChoice.ToLower() == "Schere".ToLower() || computerChoice.ToLower() == "Stein".ToLower())))
            {
        return context.Response.WriteAsync(username + ", du hast gewonnen!");
            }
    else{
        return context.Response.WriteAsync(username + ", du hast verloren!");
    }
});

app.Run();

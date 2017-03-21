#tool "RabbitMQ.Client"

var target = Argument("target", "Default");

Task("Default")
  .Does(() =>
{
  var files = GetFiles("./RabbitMQ.ps1")
            + GetFiles("./tools/RabbitMQ.Client/lib/net451/RabbitMQ.Client.dll");

  Zip("./", "OctoRabbit.zip", files);

  Information("Hello World!");
});

RunTarget(target);

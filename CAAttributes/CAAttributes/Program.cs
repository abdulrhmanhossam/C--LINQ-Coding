using System.Reflection;

namespace CAAttributes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Update[] update =
            //{
            //    new Update(1, "Security Update"),
            //    new Update(2, "UI Enhancement"),
            //    new Update(3, "Number of Bug Fixes Update"),
            //    new Update(4, "Security Update")
            //};

            ////UpdateProcessor.Download(update);
            ////UpdateProcessor.Install(update);
            //UpdateProcessor.DownloadAndInstall(update);
            
            List<Player> players = new List<Player>
            {
                new Player
                {
                    Name = "Lionel Messi",
                    BallControl = 9,
                    Dribbling = 18,
                    Passing = 4,
                    Speed = 85,
                    Power = 990,
                },
                new Player
                {
                    Name = "Christiano Ronaldo",
                    BallControl = 9,
                    Dribbling = 18,
                    Passing = 4,
                    Speed = 87,
                    Power = 980,
                },
                new Player
                {
                    Name = "Neymar Jr",
                    BallControl = 7,
                    Dribbling = 16,
                    Passing = 4,
                    Speed = 85,
                    Power = 1000,
                }

            };

            var errors = new List<Error>();
            foreach (var player in players)
            {
                var properties = player.GetType().GetProperties();
                foreach (var property in properties)
                {
                    var skillAttributes= property.GetCustomAttributes<SkillAttribute>();
                    foreach (var skillAttribute in skillAttributes)
                    {
                        if (skillAttribute is not null)
                        {
                            var value = property.GetValue(player);
                            if (!skillAttribute.IsValid(value!))
                            {
                                errors.Add(new Error(property.Name, 
                                    $"Invalid Value Accepted Range " +
                                    $"{skillAttribute.Minimum} {skillAttribute.Maximum}"));
                            }
                        }
                    }
                }
            }
            if (errors.Count > 0)
            {
                foreach (var error in errors)
                {
                    Console.WriteLine(error);
                }
            }
            else
            {
                Console.WriteLine("Player info are valid");
            }

            Console.ReadKey();
        }
    }
   
}

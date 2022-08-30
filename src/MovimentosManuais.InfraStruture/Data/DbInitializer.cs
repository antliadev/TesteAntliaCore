using System.Linq;

namespace MovimentosManuais.InfraStruture.Data
{
    public class DbInitializer
    {
        public DbInitializer(MovimentosManuaisContext context)
        {
            if (context.MovimentosManuais.Any())
            {
                return;
            }
        }
    }
}

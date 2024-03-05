using ValhallaVaultCyberGroup.Data.Data;

namespace ValhallaVaultCyberGroup.Data.Repositories
{
    public class ResultRepo
    {
        private readonly QuizDbContext context;

        public ResultRepo(QuizDbContext context)
        {
            this.context = context;
        }

        public void GetResults()
        {

        }

    }
}

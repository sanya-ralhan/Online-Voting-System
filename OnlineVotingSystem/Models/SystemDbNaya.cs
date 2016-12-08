namespace OnlineVotingSystem.Models
{
	public class SystemDbNaya : System.Data.Entity.DbContext
	{
		public System.Data.Entity.DbSet<User> Users { get; set; }
		public System.Data.Entity.DbSet<Voter> Voters { get; set; }
		public System.Data.Entity.DbSet<Candidate> Candidates { get; set; }

	}
}
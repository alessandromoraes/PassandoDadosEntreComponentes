namespace PassandoDadosEntreComponentes.Client.Services
{
	public static class RegisterServices
	{
		public static void Configure(IServiceCollection services)
		{
			services.AddSingleton<Pessoa>();
		}
	}
}

using System;


namespace R5T.F0073
{
	public class ServiceNameOperator : IServiceNameOperator
	{
		#region Infrastructure

	    public static IServiceNameOperator Instance { get; } = new ServiceNameOperator();

	    private ServiceNameOperator()
	    {
        }

	    #endregion
	}
}
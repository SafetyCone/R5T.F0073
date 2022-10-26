using System;

using R5T.T0132;


namespace R5T.F0073
{
	[FunctionalityMarker]
	public partial interface IServiceNameOperator : IFunctionalityMarker
	{
		public string GetServiceDefinitionInterfaceTypeName(string serviceDefinitionName)
        {
			// The interface definition type name *is* the service definition name.
			return serviceDefinitionName;
        }

		public string GetServiceDefinitionName(string serviceNameStem)
        {
			var serviceDefinitionName = F0000.TypeNameOperator.Instance.GetInterfaceTypeName(serviceNameStem);
			return serviceDefinitionName;
        }
	}
}
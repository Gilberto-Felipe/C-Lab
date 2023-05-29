//Para desarrollar una integración en C# que traiga información de BitLocker de Azure Active Directory a través de la API de Microsoft Graph, puedes seguir estos pasos:

//1. Registra tu aplicación en Azure Active Directory y obtén un token de acceso para autenticar tus solicitudes a la API de Microsoft Graph.
//2. Usa el SDK de Microsoft Graph para C# o realiza solicitudes HTTP directamente a la API de Microsoft Graph para obtener información sobre dispositivos y sus políticas de BitLocker.
//3. Procesa la respuesta y utiliza la información obtenida según tus necesidades.

//Aquí tienes un ejemplo de cómo obtener información sobre dispositivos y sus políticas de BitLocker usando el SDK de Microsoft Graph para C#:


var GraphServiceClient graphClient = new GraphServiceClient(
    new DelegateAuthenticationProvider(
        async (requestMessage) =>
        {
            var accessToken = await GetAccessTokenAsync();
            requestMessage.Headers.Authorization = new AuthenticationHeaderValue("Bearer", accessToken);
        }));

var devices = await graphClient.Devices
    .Request()
    .Select("id,displayName,deviceKey")
    .GetAsync();

foreach (var device in devices)
{
    Console.WriteLine($"Device ID: {device.Id}");
    Console.WriteLine($"Device Name: {device.DisplayName}");

    var bitlockerPolicies = await graphClient.DeviceManagement.ManagedDevices[device.Id].DeviceCompliancePolicyStates
        .Request()
        .Filter("policyType eq 'bitLocker'")
        .GetAsync();

    foreach (var policy in bitlockerPolicies)
    {
        Console.WriteLine($"BitLocker Policy ID: {policy.Id}");
        Console.WriteLine($"BitLocker Policy Name: {policy.DisplayName}");
        Console.WriteLine($"BitLocker Policy State: {policy.State}");
    }
}

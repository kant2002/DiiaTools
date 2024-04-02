using Grpc.Core;

namespace Ua.Gov.Diia.Crypto;

public class СервісBankId : BankIdCryptoService.BankIdCryptoServiceBase
{
	private readonly ILogger<СервісBankId> _logger;
	public СервісBankId(ILogger<СервісBankId> logger)
	{
		_logger = logger;
	}

	public override Task<GenerateCertificateResponse> generateCertificate(GenerateCertificateRequest request, ServerCallContext context)
	{
		return Task.FromResult(new GenerateCertificateResponse() { Cert = "12345678" });
	}

	public override Task<DevelopUserDataResponse> decrypt(DevelopUserDataRequest request, ServerCallContext context)
	{
		return Task.FromResult(new DevelopUserDataResponse() { Data = """
			{
				"type": "type",
				"firstName": "type",
				"middleName": "type",
				"lastName": "type",
				"phone": "type",
				"inn": "8111111111",
				"birthDay": "type",
				"sex": "type",
				"email": "type",
				"addresses": [],
				"documents": []
			}
			""" });
	}
}

using B2.Net.Tests;
using B2Net.Models;

namespace B2Net.Tests {
	public class BaseTest {
		public B2Options Options { get; set; }

		//TODO: Alterar credenciais
		protected string applicationKey = "00022d3d9f6579050f1fea8606aca29ca9e324a689";
		protected string applicationKeyId = "16ba0ce97c1d";

		protected string restrictedApplicationKey = "K0001Uev/N/Sd8dvVuP0vojW0D57wgc";
		protected string restrictedApplicationKeyId = "00016ba0ce97c1d0000000003";

		public BaseTest() {
			Options = new B2Options() {
				KeyId = TestConstants.KeyId,
				ApplicationKey = TestConstants.ApplicationKey
			};
		}
	}
}

using B2.Net.Tests;
using B2Net.Models;

namespace B2Net.Tests {
	public class BaseTest {
		public B2Options Options { get; set; }

		//TODO: Alterar credenciais
		protected string applicationKey = "";
		protected string applicationKeyId = "";

		protected string restrictedApplicationKey = "";
		protected string restrictedApplicationKeyId = "";

		public BaseTest() {
			Options = new B2Options() {
				KeyId = TestConstants.KeyId,
				ApplicationKey = TestConstants.ApplicationKey
			};
		}
	}
}

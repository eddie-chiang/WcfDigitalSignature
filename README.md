# WcfDigitalSignature
WCF example of digital signature in SOAP.

Sample SOAP request:

	<s:Envelope xmlns:s="http://www.w3.org/2003/05/soap-envelope" xmlns:u="http://docs.oasis-open.org/wss/2004/01/oasis-200401-wss-wssecurity-utility-1.0.xsd">
		<s:Header>
			<VsDebuggerCausalityData xmlns="http://schemas.microsoft.com/vstudio/diagnostics/servicemodelsink">uIDPo1iR5okLhJxGiOyqeuZpf5gAAAAA2VtTwYb0AEGM2xIj2Id0eWpnXJDNvq1EoVro7jeE2BsACQAA</VsDebuggerCausalityData>
			<o:Security s:mustUnderstand="1" xmlns:o="http://docs.oasis-open.org/wss/2004/01/oasis-200401-wss-wssecurity-secext-1.0.xsd">
				<u:Timestamp u:Id="uuid-64dca7df-eee7-4041-87fb-3484178526c0-1">
					<u:Created>2017-07-19T23:58:35.753Z</u:Created>
					<u:Expires>2017-07-19T23:58:40.753Z</u:Expires>
				</u:Timestamp>
				<o:BinarySecurityToken>
					<!-- Removed-->
				</o:BinarySecurityToken>
				<Signature xmlns="http://www.w3.org/2000/09/xmldsig#">
					<SignedInfo>
						<CanonicalizationMethod Algorithm="http://www.w3.org/2001/10/xml-exc-c14n#"/>
						<SignatureMethod Algorithm="http://www.w3.org/2001/04/xmldsig-more#rsa-sha256"/>
						<Reference URI="#uuid-64dca7df-eee7-4041-87fb-3484178526c0-1">
							<Transforms>
								<Transform Algorithm="http://www.w3.org/2001/10/xml-exc-c14n#"/>
							</Transforms>
							<DigestMethod Algorithm="http://www.w3.org/2001/04/xmlenc#sha256"/>
							<DigestValue>gQDwPIAlOfyYnIwK1uH76ZKcgzgFlUKETwIJ3lqdNzM=</DigestValue>
						</Reference>
					</SignedInfo>
					<SignatureValue>Sm9E76fv8BjigO77tKA6AU06Zr3rgofOvIokJMLdVRLoPXxxFFmPHF64VkWUNNakGJwkvlXqNY5I69AUI2r1aWvpSl3PT88GNgAeCBTw7OmcIN60pVZUXhwiJBbEDdXQcSlc4q6cqTYJYcgO56uN4xFy17Q2yqHYb/j5dHWW6C2lBDUmXHe9HKjdI2b6BJXT4QCNicQCanED+i6IMFaDYE2Nkl0Qo2fyORkzsr7aVVeq8MQw4YnxERL9RQkMaLk2igNe/+RKXxhxgG/0o9BT8Ld9UXyB6yacFFMdpcriklA5X6aiC76TO+25W3AVu17UzJB3HTDwHFXdQdmfEXPG1Q==</SignatureValue>
					<KeyInfo>
						<o:SecurityTokenReference>
							<o:Reference ValueType="http://docs.oasis-open.org/wss/2004/01/oasis-200401-wss-x509-token-profile-1.0#X509v3" URI="#uuid-0b187803-fa53-4ace-aa17-17c5eb333760-2"/>
						</o:SecurityTokenReference>
					</KeyInfo>
				</Signature>
			</o:Security>
		</s:Header>
		<s:Body>
			<Echo xmlns="http://tempuri.org/">
				<value>Hello World</value>
			</Echo>
		</s:Body>
	</s:Envelope>

<?xml version="1.0" encoding="utf-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform"
    xmlns:msxsl="urn:schemas-microsoft-com:xslt" exclude-result-prefixes="msxsl"
>
          <xsl:template match="/ArrayOfOrder">
          <html>
			<head>
				<title>订单列表</title>
			</head>
			<body>
				<table border="1" cellspacing="0">
					<tr>
						<th>订单号</th>
						<th>客户名</th>
						<th>客户手机号码</th>
					</tr>
					<xsl:for-each select="orders">
						<tr>
							<td><xsl:value-of select="NextOrderID" /></td>
							<td><xsl:value-of select="NextCilentName" /></td>
							<td><xsl:value-of select="NextCilentTelephoneNumber" /></td>
						</tr>
					</xsl:for-each>
				</table>
			</body>
		</html>
      	</xsl:template>
</xsl:stylesheet>
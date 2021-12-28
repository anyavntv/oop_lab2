<?xml version="1.0" encoding="utf-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
	<xsl:output method="html"></xsl:output>

	<xsl:template match="/">
		<html>
			<body>
				<table border = "5" bordercolor="purple">
					<TR>
						<th>Manufacturer</th>
						<th>Model</th>
						<th>Serialnumber</th>
						<th>Price</th>
						<th>Condition</th>
						<th>OS</th>
					</TR>
					<xsl:for-each select= "LaptopCatalog/Laptop">
						<tr>
							<td>
								<xsl:value-of select="@Manufacturer"/>
							</td>
							<td>
								<xsl:value-of select="@Model"/>
							</td>
							<td>
								<xsl:value-of select="@SerialNumber"/>
							</td>
							<td>
								<xsl:value-of select="@Price"/>
							</td>
							<td>
								<xsl:value-of select="@Condition"/>
							</td>
							<td>
								<xsl:value-of select="@OS"/>
							</td>
						</tr>
					</xsl:for-each>
				</table>
			</body>
		</html>
	</xsl:template>
</xsl:stylesheet>

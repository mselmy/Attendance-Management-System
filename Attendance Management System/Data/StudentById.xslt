<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
	<xsl:output method="xml" version="1.0" encoding="UTF-8" indent="yes"/>
	<xsl:param name="Id" select="''"/>
	<xsl:template match="/">
		<records>
			<xsl:apply-templates select="school/attendance-records/attendance-record[student/@id = $Id]"/>
		</records>
	</xsl:template>
	<xsl:template match="attendance-record">
		<record>
			<classId>
				<xsl:value-of select="class/id"/>
			</classId>
			<StudentId>
				<xsl:value-of select="student/@id"/>
			</StudentId>
			<State>
				<xsl:value-of select="student/status"/>
			</State>
			<date>
				<xsl:value-of select="date"/>
			</date>
		</record>
	</xsl:template>
</xsl:stylesheet>

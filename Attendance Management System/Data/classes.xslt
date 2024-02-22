<?xml version="1.0" encoding="UTF-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">

  <xsl:template match="/">
    <classes>
      <xsl:apply-templates select="//class"/>
    </classes>
  </xsl:template>

  <xsl:template match="class">
    <class>
      <id><xsl:value-of select="id"/></id>
      <name><xsl:value-of select="name"/></name>
    </class>
  </xsl:template>
</xsl:stylesheet>

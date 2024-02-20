<?xml version="1.0" encoding="UTF-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
    <xsl:output method="xml"/>
    
    <xsl:template match="/school">
        <xsl:for-each select="classes/class">
            <xsl:value-of select="id"/>
        </xsl:for-each>
    </xsl:template>
</xsl:stylesheet>

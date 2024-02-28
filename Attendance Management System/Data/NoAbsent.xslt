<?xml version="1.0" encoding="UTF-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
    <xsl:output method="xml" version="1.0" encoding="UTF-8" indent="yes"/>
    
    <xsl:param name="WarningThreshold" select="''" />
    
    <xsl:template match="/">
        <absent-students>
            <xsl:apply-templates select="school/students/student"/>
        </absent-students>
    </xsl:template>
    
    <xsl:template match="student">
    
        <xsl:variable name="absentDays" select="count(//attendance-record/student[@id=current()/@id and status='Absent'])"/>
        
       
        <xsl:if test="$absentDays &gt;= $WarningThreshold">
            <student>
                <id>
                    <xsl:value-of select="@id"/>
                </id>
                <name>
                    <xsl:value-of select="name"/>
                </name>
                <absent-days>
                    <xsl:value-of select="$absentDays"/>
                </absent-days>
            </student>
        </xsl:if>
    </xsl:template>
</xsl:stylesheet>

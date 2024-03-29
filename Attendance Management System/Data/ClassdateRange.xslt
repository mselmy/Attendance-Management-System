<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
    <xsl:output method="xml" version="1.0" encoding="UTF-8" indent="yes"/>

    <xsl:param name="startDate" select="''"/>
    <xsl:param name="endDate" select="''"/>
    <xsl:param name="Id" select="''"/>


    <xsl:key name="student-id" match="students/student" use="@id"/>
    
    <xsl:key name="class-id" match="classes/class" use="id"/>
    
    <xsl:template match="/">
        <records>
            <xsl:apply-templates select="school/attendance-records/attendance-record[number(translate(date, '-', '')) &gt;= number(translate($startDate, '-', '')) and number(translate(date, '-', '')) &lt;= number(translate($endDate, '-', '')) and class/id=$Id]"/>
        </records>
    </xsl:template>

    <xsl:template match="attendance-record">
        <xsl:for-each select="student">
            <record>
                <classId><xsl:value-of select="../class/id"/></classId>
                 <ClassName>
                    <xsl:value-of select="key('class-id', ../class/id)/name"/>
                </ClassName>
                <StudentId><xsl:value-of select="@id"/></StudentId>
                  <StudentName>
                    <xsl:value-of select="key('student-id', @id)/name"/>
                </StudentName>
                <State><xsl:value-of select="status"/></State>
                <date><xsl:value-of select="../date"/></date>
            </record>
        </xsl:for-each>
    </xsl:template>
</xsl:stylesheet>

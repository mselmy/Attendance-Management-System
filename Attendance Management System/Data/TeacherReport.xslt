<?xml version="1.0" encoding="UTF-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
    <xsl:param name="teacherId" select="''"/>
    <xsl:param name="startDate" select="''"/>
    <xsl:param name="endDate" select="''"/>
    
    <xsl:key name="student-id" match="students/student" use="@id"/>
    <xsl:key name="class-id" match="classes/class" use="id"/>
    
   
    <xsl:template match="/school">
        <xsl:variable name="courses" select="//teachers/teacher[@id = $teacherId]/courses/course/@id"/>
        <records>
            <xsl:apply-templates select="attendance-records/attendance-record[class/id = $courses and number(translate(date, '-', '')) &gt;= number(translate($startDate, '-', '')) and number(translate(date, '-', '')) &lt;= number(translate($endDate, '-', ''))]"/>

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

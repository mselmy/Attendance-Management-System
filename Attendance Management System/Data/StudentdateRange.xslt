<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
    <xsl:output method="xml" indent="yes"/>
    <xsl:param name="startDate" select="'2024-01-01'"/>
    <xsl:param name="endDate" select="'2024-02-22'"/>
    <xsl:param name="Id" select="'ST-1'"/>
    
    <xsl:key name="student-id" match="students/student" use="@id"/>
    
    <xsl:key name="class-id" match="classes/class" use="id"/>
    
    <xsl:template match="/">
        <records>
      
            <xsl:apply-templates select="school/attendance-records/attendance-record[number(translate(date, '-', '')) &gt;= number(translate($startDate, '-', '')) and number(translate(date, '-', '')) &lt;= number(translate($endDate, '-', '')) and student/@id = $Id]"/>
        </records>
    </xsl:template>
    
    <xsl:template match="attendance-record">
        <record>
           <classId>
                <xsl:value-of select="class/id"/>
            </classId>
              <ClassName>
                    <xsl:value-of select="key('class-id',class/id)/name"/>
                </ClassName>
            <xsl:for-each select="student">
                <xsl:if test="@id=$Id">
                    <StudentId>
                        <xsl:value-of select="@id"/>
                    </StudentId>
                    <StudentName>
                        <xsl:value-of select="key('student-id', $Id)/name"/>
                    </StudentName>
                    <State>
                        <xsl:value-of select="status"/>
                    </State>
                  
                </xsl:if>
            </xsl:for-each>
            <date>
                <xsl:value-of select="date"/>
            </date>
        </record>
    </xsl:template>
</xsl:stylesheet>

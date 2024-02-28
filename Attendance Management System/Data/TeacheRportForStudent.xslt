<?xml version="1.0" encoding="UTF-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
	<xsl:output method="xml" version="1.0" encoding="UTF-8" indent="yes"/>
	<xsl:param name="teacherId" select="'TE-1'"/>
	<xsl:param name="studId" select="'ST-1'"/>
	<xsl:param name="startDate" select="'2023-02-02'"/>
	<xsl:param name="endDate" select="'2024-02-04'"/>
	
	
	<xsl:key name="student-id" match="students/student" use="@id"/>
	<xsl:key name="class-id" match="classes/class" use="id"/>
	
	<xsl:template match="/school">
	 <xsl:variable name="courses" select="//teachers/teacher[@id = $teacherId]/courses/course/@id"/>
        <records>
            <xsl:apply-templates select="attendance-records/attendance-record[class/id = $courses  
 and student/@id=$studId and number(translate(date, '-', '')) &gt;= number(translate($startDate, '-', '')) and number(translate(date, '-', '')) &lt;= number(translate($endDate, '-', ''))]"/>

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
                <xsl:if test="@id=$studId">
                    <StudentId>
                        <xsl:value-of select="@id"/>
                    </StudentId>
                    <StudentName>
                        <xsl:value-of select="key('student-id', $studId)/name"/>
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


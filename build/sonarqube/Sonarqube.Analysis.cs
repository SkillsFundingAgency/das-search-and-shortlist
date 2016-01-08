<?xml version="1.0" encoding="utf-8" ?>
<!--
  This file defines properties which would be understood by the SonarQube Scanner for MSBuild, if not overridden (see below)
  By default the MSBuild.SonarQube.Runner.exe picks-up a file named SonarQube.Analysis.xml in the folder it
  is located (if it exists). It is possible to use another properties file by using the /s:filePath.xml flag
  
  The overriding strategy of property values is the following:
  - A project-specific property defined in the MSBuild *.*proj file (corresponding to a SonarQube module) can override:
  - A property defined in the command line (/d:propertyName=value) has which can override:
  - A property defined in the SonarQube.Analysis.xml configuration file [this file] which can override:
  - A property defined in the SonarQube User Interface at project level which can override:
  - A property defined in the SonarQube User Interface at global level which can't override anything.
  
  Note that the following properties cannot be set through an MSBuild project file or an SonarQube.Analysis.xml file:
  sonar.projectName, sonar.projectKey, sonar.projectVersion
  The following flags need to be used to set their value: /n:[SonarQube Project Name] /k:[SonarQube Project Key] /v:[SonarQube Project Version]
-->
<SonarQubeAnalysisProperties  xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance" xmlns:xsd="http://www.w3.org/2001/XMLSchema" xmlns="http://www.sonarsource.com/msbuild/integration/2015/1">

  <!--<Property Name="sonar.host.url">http://localhost:9000</Property>-->

  <Property Name="sonar.verbose">true</Property>
  <!--
  <Property Name="sonar.login"></Property>
  <Property Name="sonar.password"></Property>
  -->

  <!-- Required only for versions of SonarQube prior to 5.2 -->
  <!--
  <Property Name="sonar.jdbc.url">jdbc:jtds:sqlserver://mySqlServer/sonar;instance=SQLEXPRESS;SelectMethod=Cursor</Property>
  <Property Name="sonar.jdbc.username">sonar</Property>
  <Property Name="sonar.jdbc.password">sonar</Property>
  -->

</SonarQubeAnalysisProperties>
<?xml version="1.0" encoding="utf-8"?>
<iso:schema queryBinding="xslt2" xmlns:iso="http://purl.oclc.org/dsdl/schematron">
  <!-- NC1 V.9.0.0 -->
  <iso:ns uri="http://www.w3.org/2001/XMLSchema-instance" prefix="xsi" />
  <iso:ns uri="urn:fra:nc1:objet:intelrequirement" prefix="nc1intelreq" />
  <iso:pattern>
    <iso:title>NC1_IntelRequirement validation rules</iso:title>
    <iso:rule context="/nc1intelreq:NC1_IntelRequirement/@id">
      <iso:assert test="matches(.,'^39:')" diagnostics="D26793-en">NC1_IntelRequirement.2: Le type de l'objet doit avoir pour valeur 39</iso:assert>
    </iso:rule>
    <iso:rule context="/nc1intelreq:NC1_IntelRequirement/location/tacAreaId/@id">
      <iso:assert test="matches(.,'^42:')" diagnostics="D26792-en">NC1_IntelRequirement.3: Le besoin en renseignement doit être localisé au moyen d'un point tactique (NC1_TacPoint), d'une ligne tactique (NC1_TacLine), d'une surface tactique (NC1_TacArea), ou d'une forme graphique.</iso:assert>
    </iso:rule>
    <iso:rule context="/nc1intelreq:NC1_IntelRequirement/location/tacLineId/@id">
      <iso:assert test="matches(.,'^41:')" diagnostics="D26790-en">NC1_IntelRequirement.3: Le besoin en renseignement doit être localisé au moyen d'un point tactique (NC1_TacPoint), d'une ligne tactique (NC1_TacLine), d'une surface tactique (NC1_TacArea), ou d'une forme graphique.</iso:assert>
    </iso:rule>
    <iso:rule context="/nc1intelreq:NC1_IntelRequirement/location/tacPointId/@id">
      <iso:assert test="matches(.,'^40:')" diagnostics="D26791-en">NC1_IntelRequirement.3: Le besoin en renseignement doit être localisé au moyen d'un point tactique (NC1_TacPoint), d'une ligne tactique (NC1_TacLine), d'une surface tactique (NC1_TacArea), ou d'une forme graphique.</iso:assert>
    </iso:rule>
  </iso:pattern>
  <iso:diagnostics>
    <iso:diagnostic xml:lang="en" id="D26790-en">NC1_IntelRequirement.3: The intelligence need shall be localized through a tactical point (NC1_TacPoint), a tactical line (NC1_TacLine), a tactical area (NC1_TacArea), or graphic shape.</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26791-en">NC1_IntelRequirement.3: The intelligence need shall be localized through a tactical point (NC1_TacPoint), a tactical line (NC1_TacLine), a tactical area (NC1_TacArea), or graphic shape.</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26792-en">NC1_IntelRequirement.3: The intelligence need shall be localized through a tactical point (NC1_TacPoint), a tactical line (NC1_TacLine), a tactical area (NC1_TacArea), or graphic shape.</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26793-en">NC1_IntelRequirement.2: The type of the object has to have for value 39</iso:diagnostic>
  </iso:diagnostics>
</iso:schema>
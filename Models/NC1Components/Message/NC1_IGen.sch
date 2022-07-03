<?xml version="1.0" encoding="utf-8"?>
<iso:schema queryBinding="xslt2" xmlns:iso="http://purl.oclc.org/dsdl/schematron">
  <!-- NC1 V.9.0.0 -->
  <iso:ns uri="http://www.w3.org/2001/XMLSchema-instance" prefix="xsi" />
  <iso:ns uri="urn:fra:nc1:message:igen" prefix="nc1igen" />
  <iso:pattern>
    <iso:title>NC1_IGen validation rules</iso:title>
    <iso:rule context="/nc1igen:NC1_IGen/generalOrder/fireObjectiveId/@id">
      <iso:assert test="matches(.,'^(36):')" diagnostics="D26503-en">NC1_IGen.2: L'objectif feux sur lequel les tirs doivent être arrêtés doit être un objet NC1_FireObjective.</iso:assert>
    </iso:rule>
    <iso:rule context="/nc1igen:NC1_IGen/generalOrder/tacAreaId/@id">
      <iso:assert test="matches(.,'^(42):')" diagnostics="D26502-en">NC1_IGen.2: La zone tactique 2D dans laquelle les tirs doivent être arrêtés doit être un objet NC1_TacArea.</iso:assert>
    </iso:rule>
  </iso:pattern>
  <iso:diagnostics>
    <iso:diagnostic xml:lang="en" id="D26502-en">NC1_IGen.2: The 2D tactical area in which the fires must be held shall be a NC1_TacArea object.</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26503-en">NC1_IGen.2: The fire objective where the fires must be stopped should be a  NC1_FireObjective object.</iso:diagnostic>
  </iso:diagnostics>
</iso:schema>
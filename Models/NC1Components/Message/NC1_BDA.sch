<?xml version="1.0" encoding="utf-8"?>
<iso:schema queryBinding="xslt2" xmlns:iso="http://purl.oclc.org/dsdl/schematron">
  <!-- NC1 V.9.0.0 -->
  <iso:ns uri="http://www.w3.org/2001/XMLSchema-instance" prefix="xsi" />
  <iso:ns uri="urn:fra:nc1:message:bda" prefix="nc1bda" />
  <iso:pattern>
    <iso:title>NC1_BDA validation rules</iso:title>
    <iso:rule context="/nc1bda:NC1_BDA/battleDamageAssessment/source/observerId/@id">
      <iso:assert test="matches(.,'^(0|9|10|11):')" diagnostics="D26492-en">NC1_BDA.2: L'observateur des dommages causés doit être soit une unité (NC1_Unit), soit un participant (NC1_GroundParticipant, NC1_SeaParticipant ou NC1_AirParticipant).</iso:assert>
    </iso:rule>
    <iso:rule context="/nc1bda:NC1_BDA/battleDamageAssessment">
      <iso:assert test="count(fireReference) + count(fireObjectiveReference) &gt; 0" diagnostics="D26493-en">NC1_BDA.4: La référence du tir ou celle de l'objectif feux doit être renseignée.</iso:assert>
    </iso:rule>
  </iso:pattern>
  <iso:diagnostics>
    <iso:diagnostic xml:lang="en" id="D26492-en">NC1_BDA.2: The observer of the damage must be either a unit (NC1_Unit) or a participant (NC1_GroundParticipant, NC1_SeaParticipant or NC1_AirParticipant).</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26493-en">NC1_BDA.4: The reference of the fire or fire objective shall be provided.</iso:diagnostic>
  </iso:diagnostics>
</iso:schema>
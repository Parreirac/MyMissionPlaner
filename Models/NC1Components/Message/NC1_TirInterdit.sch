﻿<?xml version="1.0" encoding="utf-8"?>
<iso:schema queryBinding="xslt2" xmlns:iso="http://purl.oclc.org/dsdl/schematron">
  <!-- NC1 V.9.0.0 -->
  <iso:ns uri="http://www.w3.org/2001/XMLSchema-instance" prefix="xsi" />
  <iso:ns uri="urn:fra:nc1:message:tirinterdit" prefix="nc1tirinterdit" />
  <iso:pattern>
    <iso:title>NC1_TirInterdit validation rules</iso:title>
    <iso:rule context="/nc1tirinterdit:NC1_TirInterdit/zone/volume/geometricalShape/airtrack/segment">
      <iso:assert test="if (minLevelReference=2) then maxLevelReference=2 else true()" diagnostics="D26534-en">NC1_TirInterdit.3: Si la référence d'altitude minimale est 2 (Flight Level), alors la référence d'altitude maximale doit aussi valoir 2 (Flight Level).</iso:assert>
    </iso:rule>
    <iso:rule context="/nc1tirinterdit:NC1_TirInterdit/zone/volume/levels">
      <iso:assert test="if (minLevelReference=2) then maxLevelReference=2 else true()" diagnostics="D26533-en">NC1_TirInterdit.3: Si la référence d'altitude minimale est 2 (Flight Level), alors la référence d'altitude maximale doit aussi valoir 2 (Flight Level).</iso:assert>
    </iso:rule>
  </iso:pattern>
  <iso:diagnostics>
    <iso:diagnostic xml:lang="en" id="D26533-en">NC1_TirInterdit.3: If the reference of minimal height is 2 ( Flight Level), then the reference of maximal height also has to be worth 2 ( Flight Level).</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26534-en">NC1_TirInterdit.3: If the reference of minimal height is 2 ( Flight Level), then the reference of maximal height also has to be worth 2 ( Flight Level).</iso:diagnostic>
  </iso:diagnostics>
</iso:schema>
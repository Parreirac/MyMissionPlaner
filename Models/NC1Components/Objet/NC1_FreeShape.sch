<?xml version="1.0" encoding="utf-8"?>
<iso:schema queryBinding="xslt2" xmlns:iso="http://purl.oclc.org/dsdl/schematron">
  <!-- NC1 V.9.0.0 -->
  <iso:ns uri="http://www.w3.org/2001/XMLSchema-instance" prefix="xsi" />
  <iso:ns uri="urn:fra:nc1:objet:freeshape" prefix="nc1freeshape" />
  <iso:pattern>
    <iso:title>NC1_FreeShape validation rules</iso:title>
    <iso:rule context="/nc1freeshape:NC1_FreeShape/tacticalData/style/line/type">
      <iso:assert test=". != 0">NC1_FreeShape.1: Le type de la forme libre de style ligne ne peut être égal à 0.</iso:assert>
    </iso:rule>
    <iso:rule context="/nc1freeshape:NC1_FreeShape/@id">
      <iso:assert test="matches(.,'^44:')" diagnostics="D26752-en">NC1_FreeShape.4: Le type de l'objet doit avoir pour valeur 44</iso:assert>
    </iso:rule>
    <iso:rule context="/nc1freeshape:NC1_FreeShape/location/point">
      <iso:assert test="not(../../tacticalData/style/line) and not(../../tacticalData/style/area)" diagnostics="D26753-en">NC1_FreeShape.5: Dans le cas où la localisation est un point alors la forme ne peut être ni une ligne ni une zone.</iso:assert>
    </iso:rule>
    <iso:rule context="/nc1freeshape:NC1_FreeShape/location">
      <iso:assert test="if (polygon or rectangle or circle or ellipse or arcband or corridor) then not(../tacticalData/style/point) and not(../tacticalData/style/line) else true()">NC1_FreeShape.6: Dans le cas où la localisation est un polygone ou un rectangle ou un cercle ou  une ellipse ou un radarc ou un corridor alors la forme ne peut être ni un point ni une ligne.</iso:assert>
    </iso:rule>
    <iso:rule context="/nc1freeshape:NC1_FreeShape/location/polyline">
      <iso:assert test="not(../../tacticalData/style/point) and not(../../tacticalData/style/area)">NC1_FreeShape.7: Dans le cas où la localisation est une polyligne alors la forme ne peut être ni un point ni une zone.</iso:assert>
    </iso:rule>
  </iso:pattern>
  <iso:diagnostics>
    <iso:diagnostic xml:lang="en" id="D26752-en">NC1_FreeShape.4: The type of the object has to have for value 44</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26753-en">NC1_FreeShape.5: The 13th and 14th characters of the Symbol Code must correspond to a value from the L105_2Code dictionary.</iso:diagnostic>
  </iso:diagnostics>
</iso:schema>
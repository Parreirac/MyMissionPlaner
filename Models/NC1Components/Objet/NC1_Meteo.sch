<?xml version="1.0" encoding="utf-8"?>
<iso:schema queryBinding="xslt2" xmlns:iso="http://purl.oclc.org/dsdl/schematron">
  <!-- NC1 V.9.0.0 -->
  <iso:ns uri="http://www.w3.org/2001/XMLSchema-instance" prefix="xsi" />
  <iso:ns uri="urn:fra:nc1:objet:meteo" prefix="nc1meteo" />
  <iso:pattern>
    <iso:title>NC1_Meteo validation rules</iso:title>
    <iso:rule context="/nc1meteo:NC1_Meteo/tacticalData/symbolCode">
      <iso:assert test="matches(., '^APP6B:W-A.......-----')" diagnostics="D26939-en">NC1_Meteo.2: Le standard de symbologie utilisé doit être l'APP-6(B). Le code symbole d'un objet météo doit être dans la famille W-A*******----- .</iso:assert>
      <iso:assert test="matches(.,':...[AP]')">NC1_Meteo.7: Le 4ème caractère du Code symbole doit correspondre aux valeurs 'A' ou 'P'.</iso:assert>
    </iso:rule>
    <iso:rule context="/nc1meteo:NC1_Meteo/@id">
      <iso:assert test="matches(.,'^32:')" diagnostics="D26942-en">NC1_Meteo.4: Le type de l'objet doit avoir pour valeur 32</iso:assert>
    </iso:rule>
    <iso:rule context="/nc1meteo:NC1_Meteo/location">
      <iso:assert test="if (matches(../tacticalData/symbolCode,':...A')) then count(datetime) + count(quality) = 0 else true()" diagnostics="D26940-en">NC1_Meteo.5: Lorsqu'il s'agit d'une prévision météo, l'horodatage du relevé de sa position sur le terrain et la qualité de la mesure de localisation ne doivent pas être renseignés.</iso:assert>
    </iso:rule>
    <iso:rule context="/nc1meteo:NC1_Meteo/tacticalData">
      <iso:assert test="if (matches(symbolCode, ':...P')) then count(probabilityRatio) = 0 else true()" diagnostics="D26941-en">NC1_Meteo.6: Lorsqu'il s'agit d'une observation ou d'une mesure météo, la probabilité de réalisation du phénomène météo ne doit pas être renseignée.</iso:assert>
    </iso:rule>
  </iso:pattern>
  <iso:diagnostics>
    <iso:diagnostic xml:lang="en" id="D26939-en">NC1_Meteo.2: The used standard of symbology has to be the APP-6 ( B ). The code symbol of a meteo object has to be in the family A - W-A-----******* .</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26940-en">NC1_Meteo.5: When it is about a meteo forecast, the timestamp of the statement of its position on the ground and the quality of the measure of location(localization) must not be informed.</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26941-en">NC1_Meteo.6: For a weather observation or measurement, the probability of the meteorological event occurring shall not be provided.</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26942-en">NC1_Meteo.4: The type of the object has to have for value 32</iso:diagnostic>
  </iso:diagnostics>
</iso:schema>
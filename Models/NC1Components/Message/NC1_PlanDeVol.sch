<?xml version="1.0" encoding="utf-8"?>
<iso:schema queryBinding="xslt2" xmlns:iso="http://purl.oclc.org/dsdl/schematron">
  <!-- NC1 V.9.0.0 -->
  <iso:ns uri="http://www.w3.org/2001/XMLSchema-instance" prefix="xsi" />
  <iso:ns uri="urn:fra:nc1:message:plandevol" prefix="nc1plandevol" />
  <iso:pattern>
    <iso:title>NC1_PlanDeVol validation rules</iso:title>
    <iso:rule context="/nc1plandevol:NC1_PlanDeVol/flightPlan/_3DRoute/tacticalData/symbolCode">
      <iso:assert test="matches(.,'^APP6B:G.C.MALC--')" diagnostics="D26943-en">NC1_3DRoute.3: Le standard de symbologie utilisé doit être l'APP-6(B) et le code symbole d'un itinéraire 3D doit être dans la famille G*C*MALC--***** .</iso:assert>
      <iso:assert test="some $Pays in ($L105_2//SimpleCodeList/Row/Value[@ColumnRef='short']/SimpleValue) satisfies substring(.,19,2) = substring($Pays,1,2)" diagnostics="D26946-en">NC1_3DRoute.4: Les 13ème et 14ème caractères du Code du symbole doivent correspondre à une valeur du dictionnaire L105_2Code.</iso:assert>
    </iso:rule>
    <iso:rule context="/nc1plandevol:NC1_PlanDeVol/flightPlan/_3DRoute/@id">
      <iso:assert test="matches(.,'^46:')" diagnostics="D26945-en">NC1_3DRoute.5: Le type de l'objet doit avoir pour valeur 46</iso:assert>
    </iso:rule>
    <iso:rule context="/nc1plandevol:NC1_PlanDeVol/flightPlan/_3DRoute/tacticalData/responsibleUnitId/@id">
      <iso:assert test="matches(.,'^0:')" diagnostics="D26944-en">NC1_3DRoute.6: Le responsable de l'itinéraire 3D doit être une unité (NC1_Unit).</iso:assert>
    </iso:rule>
    <iso:rule context="/nc1plandevol:NC1_PlanDeVol/flightPlan/_3DRoute/tacticalData">
      <iso:assert test="matches(symbolCode, ':...[AP]')">NC1_3DRoute.7: Le 4ème caractère du Code du symbole doit correspondre aux valeurs 'A' ou 'P'.</iso:assert>
    </iso:rule>
    <iso:rule context="/nc1plandevol:NC1_PlanDeVol/flightPlan/_3DRoute/location/startPoint/timingInstructions">
      <iso:assert test="if (type=0 or type=1) then startDatetime and endDatetime else count(startDatetime) + count(endDatetime) = 1">NC1_3DRoute.8: Si le type de consigne vaut TENIR ou PASSER DANS alors les dates de début et de fin doivent être renseignées sinon une seule date doit être renseignée.</iso:assert>
    </iso:rule>
    <iso:rule context="/nc1plandevol:NC1_PlanDeVol/flightPlan/_3DRoute/location/segment/altitude">
      <iso:assert test="../altitudeReference">NC1_3DRoute.9: La référence de l'altitude doit être renseignée si l'altitude est renseignée.</iso:assert>
    </iso:rule>
    <iso:let name="L105_2" value="doc('../Dictionnaires/L105_2Code.gc')" />
  </iso:pattern>
  <iso:diagnostics>
    <iso:diagnostic xml:lang="en" id="D26943-en">NC1_3DRoute.3: The used standard of symbology has to be the APP-6 ( B ) and the code symbol of a 3D route has to be in the family G*C*MALC - ***** .</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26944-en">NC1_3DRoute.6: The responsible of the facility shall be a unit (NC1_Unit).</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26945-en">NC1_3DRoute.5: The type of the object has to have for value 46</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26946-en">NC1_3DRoute.4: The 13th and 14th characters of the Symbol Code must correspond to a value from the L105_2Code dictionary.</iso:diagnostic>
  </iso:diagnostics>
</iso:schema>
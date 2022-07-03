<?xml version="1.0" encoding="utf-8"?>
<iso:schema queryBinding="xslt2" xmlns:iso="http://purl.oclc.org/dsdl/schematron">
  <!-- NC1 V.9.0.0 -->
  <iso:ns uri="http://www.w3.org/2001/XMLSchema-instance" prefix="xsi" />
  <iso:ns uri="urn:fra:nc1:objet:convoy" prefix="nc1convoy" />
  <iso:pattern>
    <iso:title>NC1_Convoy validation rules</iso:title>
    <iso:rule context="/nc1convoy:NC1_Convoy/tacticalData/symbolCode">
      <iso:assert test="matches(., '^APP6B:G.C.SLC')" diagnostics="D26848-en">NC1_Convoy.2: Le standard de symbologie utilisé doit être l'APP-6(B). Le code symbole d'un convoi doit être dans la famille G*C*SLC******** .</iso:assert>
      <iso:assert test="some $Pays in ($L105_2//SimpleCodeList/Row/Value[@ColumnRef='short']/SimpleValue) satisfies substring(.,19,2) = substring($Pays,1,2)" diagnostics="D26854-en">NC1_Convoy.3: Les 13ème et 14ème caractères du Code du symbole doivent correspondre à une valeur du dictionnaire L105_2Code.</iso:assert>
      <iso:assert test="if (matches(.,':...A')) then count(../../location/datetime) + count(../../location/quality) = 0 else true()" diagnostics="D26849-en">NC1_Convoy.7: Si le convoi est anticipé, l'horodatage du relevé de sa position sur le terrain et la qualité de la mesure de localisation ne doivent pas être renseignés.</iso:assert>
      <iso:assert test="if (matches(.,':.[SHJK]')) then (../../location/quality=1 or not(../../location/quality)) else true()" diagnostics="D26852-en">NC1_Convoy.10: La localisation d'un convoi ennemi ne peut qu'être estimée.</iso:assert>
      <iso:assert test="matches(.,':...[AP]')">NC1_Convoy.11: Le 4ème caractère du Code symbole doit correspondre aux valeurs 'A' ou 'P'.</iso:assert>
    </iso:rule>
    <iso:rule context="/nc1convoy:NC1_Convoy/@id">
      <iso:assert test="matches(.,'^16:')" diagnostics="D26853-en">NC1_Convoy.6: Le type de l'objet doit avoir pour valeur 16</iso:assert>
    </iso:rule>
    <iso:rule context="/nc1convoy:NC1_Convoy/tacticalData/belongingAgentId/@id">
      <iso:assert test="matches(.,'^[0-8]:')" diagnostics="D26850-en">NC1_Convoy.8: Les membres d'un convoi doivent être des agents (NC1_Unit, NC1_Organisation ou NC1_Individual).</iso:assert>
    </iso:rule>
    <iso:rule context="/nc1convoy:NC1_Convoy/movementData/routeId/@id">
      <iso:assert test="matches(.,'^38:')" diagnostics="D26851-en">NC1_Convoy.9: L'itinéraire associé au mouvement doit être un itinéraire (NC1_Route).</iso:assert>
    </iso:rule>
    <iso:let name="L105_2" value="doc('../Dictionnaires/L105_2Code.gc')" />
  </iso:pattern>
  <iso:diagnostics>
    <iso:diagnostic xml:lang="en" id="D26848-en">NC1_Convoy.2: The used standard of symbology has to be the APP-6 ( B ). The code symbol of a convoy has to be in the family G*C*SLC ******** .</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26849-en">NC1_Convoy.7: If the convoy is anticipated, the timestamp of the statement of its position on the ground and the quality of the measure of location must not be informed.</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26850-en">NC1_Convoy.8: The members of a convoy have to be agents (NC1_Unit, NC1_Organisation or NC1_Individual).</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26851-en">NC1_Convoy.9: The route associated to the movement shall be a NC1_Route object.</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26852-en">NC1_Convoy.10: The location of the enemy convoy shall be estimated only.</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26853-en">NC1_Convoy.6: The type of the object has to have for value 16</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26854-en">NC1_Convoy.3: The 13th and 14th characters of the Symbol Code must correspond to a value from the L105_2Code dictionary.</iso:diagnostic>
  </iso:diagnostics>
</iso:schema>
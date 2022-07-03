<?xml version="1.0" encoding="utf-8"?>
<iso:schema queryBinding="xslt2" xmlns:iso="http://purl.oclc.org/dsdl/schematron">
  <!-- NC1 V.9.0.0 -->
  <iso:ns uri="http://www.w3.org/2001/XMLSchema-instance" prefix="xsi" />
  <iso:ns uri="urn:fra:nc1:objet:organisation" prefix="nc1organisation" />
  <iso:pattern>
    <iso:title>NC1_Organisation validation rules</iso:title>
    <iso:rule context="/nc1organisation:NC1_Organisation/tacticalData/symbolCode">
      <iso:assert test="matches(.,'^APP6B:S.G.(USA|--------..-)')" diagnostics="D26783-en">NC1_Organisation.2: Le standard de symbologie utilisé doit être l'APP-6(B). Le code symbole d'une organisation doit être dans les familles S*G*USA******** ou S*G*--------**- .</iso:assert>
      <iso:assert test="some $Pays in ($L105_2//SimpleCodeList/Row/Value[@ColumnRef='short']/SimpleValue) satisfies substring(.,19,2) = substring($Pays,1,2)" diagnostics="D26788-en">NC1_Organisation.3: Les 13ème et 14ème caractères du Code du symbole doivent correspondre à une valeur du dictionnaire L105_2Code.</iso:assert>
      <iso:assert test="if (matches(.,':...A')) then count(../../location/datetime)+count(../../location/quality) = 0 else true()" diagnostics="D26784-en">NC1_Organisation.6: Lorsque l'organisation est anticipée, l'horodatage du relevé de sa position sur le terrain et la qualité de la mesure de localisation ne doivent pas être renseignés.</iso:assert>
      <iso:assert test="if (matches(.,':.[SHJK]')) then (../../location/quality=1 or not(../../location/quality)) else true()" diagnostics="D26786-en">NC1_Organisation.8: La localisation d'une organisation ennemie ne peut qu'être estimée.</iso:assert>
      <iso:assert test="matches(.,':...[AP]')">NC1_Organisation.9: Le 4ème caractère du Code symbole doit correspondre aux valeurs 'A' ou 'P'.</iso:assert>
    </iso:rule>
    <iso:rule context="/nc1organisation:NC1_Organisation/@id">
      <iso:assert test="matches(.,'^2:')" diagnostics="D26787-en">NC1_Organisation.5: Le type de l'objet doit avoir pour valeur 2</iso:assert>
    </iso:rule>
    <iso:rule context="/nc1organisation:NC1_Organisation/tacticalData/responsibleUnitId/@id">
      <iso:assert test="matches(.,'^0:')" diagnostics="D26785-en">NC1_Organisation.7: Le responsable de l'organisation doit être une unité (NC1_Unit).</iso:assert>
    </iso:rule>
    <iso:let name="L105_2" value="doc('../Dictionnaires/L105_2Code.gc')" />
  </iso:pattern>
  <iso:diagnostics>
    <iso:diagnostic xml:lang="en" id="D26783-en">NC1_Organisation.2: The used standard of symbology has to be the APP-6 ( B ). The code symbol of an organization has to be in families S*G*USA ******** or S*G* **--------- .</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26784-en">NC1_Organisation.6: When the organization is anticipated, the timestamp of the statement of its position on the ground and the quality of the measure of location should not be informed.</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26785-en">NC1_Organisation.7: The responsible of the organisation shall be a unit (NC1_Unit).</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26786-en">NC1_Organisation.8: The location of the enemy organisation shall be estimated only.</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26787-en">NC1_Organisation.5: The type of the object has to have for value 2</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26788-en">NC1_Organisation.3: The 13th and 14th characters of the Symbol Code must correspond to a value from the L105_2Code dictionary.</iso:diagnostic>
  </iso:diagnostics>
</iso:schema>
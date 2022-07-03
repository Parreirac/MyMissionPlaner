<?xml version="1.0" encoding="utf-8"?>
<iso:schema queryBinding="xslt2" xmlns:iso="http://purl.oclc.org/dsdl/schematron">
  <!-- NC1 V.9.0.0 -->
  <iso:ns uri="http://www.w3.org/2001/XMLSchema-instance" prefix="xsi" />
  <iso:ns uri="urn:fra:nc1:objet:facility" prefix="nc1facility" />
  <iso:pattern>
    <iso:title>NC1_Facility validation rules</iso:title>
    <iso:rule context="/nc1facility:NC1_Facility/tacticalData">
      <iso:assert test="if (frSpecificSymbol) then some $symbolCode in ($FacilityFrSpecific//SimpleCodeList/Row/Value[@ColumnRef='code'][SimpleValue=current()/frSpecificSymbol]/../Value[@ColumnRef='codeSymbole']/SimpleValue) satisfies matches(symbolCode,$symbolCode) else some $symbolCode in ($FacilitySymbol//SimpleCodeList/Row/Value[@ColumnRef='codeSymbole']/SimpleValue) satisfies matches(symbolCode,$symbolCode)" diagnostics="D26358-en">NC1_Facility.1: Si la spécialisation Fr du code symbole est renseigné alors le code du symbole renseigné doit être celui correspondant à la valeur du dictionnaire des codes symboles spécifiques sinon il doit appartenir à l'une des valeur du dictionnaire des codes symboles autorisés.</iso:assert>
    </iso:rule>
    <iso:rule context="/nc1facility:NC1_Facility/tacticalData/symbolCode">
      <iso:assert test="some $Pays in ($L105_2//SimpleCodeList/Row/Value[@ColumnRef='short']/SimpleValue) satisfies substring(.,19,2) = substring($Pays,1,2)" diagnostics="D26364-en">NC1_Facility.2: Les 13ème et 14ème caractères du Code du symbole doivent correspondre à une valeur du dictionnaire L105_2Code.</iso:assert>
      <iso:assert test="if (matches(.,':...A')) then count(../../location/datetime) + count(../../location/quality) = 0 else true()" diagnostics="D26359-en">NC1_Facility.6: Lorsque l'installation est anticipée, l'horodatage du relevé de sa position sur le terrain et la qualité de la mesure de localisation ne doivent pas être renseignés.</iso:assert>
      <iso:assert test="if (matches(.,':.[SHJK]')) then (../../location/quality=1 or not(../../location/quality)) else true()" diagnostics="D26362-en">NC1_Facility.9: La localisation d'une installation ennemie ne peut qu'être estimée.</iso:assert>
      <iso:assert test="matches(.,':...[AP]')">NC1_Facility.10: Le 4ème caractère du Code symbole doit correspondre aux valeurs 'A' ou 'P'.</iso:assert>
    </iso:rule>
    <iso:rule context="/nc1facility:NC1_Facility/@id">
      <iso:assert test="matches(.,'^18:')" diagnostics="D26363-en">NC1_Facility.5: Le type de l'objet doit avoir pour valeur 18</iso:assert>
    </iso:rule>
    <iso:rule context="/nc1facility:NC1_Facility/tacticalData/responsibleUnitId/@id">
      <iso:assert test="matches(.,'^0:')" diagnostics="D26360-en">NC1_Facility.7: Le responsable de l'installation doit être une unité (NC1_Unit).</iso:assert>
    </iso:rule>
    <iso:rule context="/nc1facility:NC1_Facility/medicalFacilityData/admittedIndividualId/@id">
      <iso:assert test="matches(.,'^3:')" diagnostics="D26361-en">NC1_Facility.8: La personne admise dans une installation médicale doit être un individu (NC1_Individual).</iso:assert>
    </iso:rule>
    <iso:let name="FacilityFrSpecific" value="doc('../Dictionnaires/FacilityFrSpecificCode.gc')" />
    <iso:let name="L105_2" value="doc('../Dictionnaires/L105_2Code.gc')" />
    <iso:let name="FacilitySymbol" value="doc('../Dictionnaires/FacilitySymbolCode.gc')" />
  </iso:pattern>
  <iso:diagnostics>
    <iso:diagnostic xml:lang="en" id="D26358-en">NC1_Facility.1: If the specialization Fr of the symbol code is filled in then the code of the filled in symbol must be the one corresponding to the value of the dictionary of specific symbol codes otherwise it must belong to one of the values ??of the dictionary of authorized symbol codes.</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26359-en">NC1_Facility.6: When the installation is anticipated, the timestamp of the statement of its position on the ground and the quality of the measure of location should not be informed.</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26360-en">NC1_Facility.7: The responsible of the 3D route shall be a unit (NC1_Unit).</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26361-en">NC1_Facility.8: The person admitted in a medical installation has to be an individual ( NC1_Individual).</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26362-en">NC1_Facility.9: The location of the enemy facility shall be estimated only.</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26363-en">NC1_Facility.5: The type of the object has to have for value 18</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26364-en">NC1_Facility.2: The 13th and 14th characters of the Symbol Code must correspond to a value from the L105_2Code dictionary.</iso:diagnostic>
  </iso:diagnostics>
</iso:schema>
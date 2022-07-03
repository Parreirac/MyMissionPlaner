<?xml version="1.0" encoding="utf-8"?>
<iso:schema queryBinding="xslt2" xmlns:iso="http://purl.oclc.org/dsdl/schematron">
  <!-- NC1 V.9.0.0 -->
  <iso:ns uri="http://www.w3.org/2001/XMLSchema-instance" prefix="xsi" />
  <iso:ns uri="urn:fra:nc1:message:initodb" prefix="nc1initodb" />
  <iso:pattern>
    <iso:title>NC1_InitOdb validation rules</iso:title>
    <iso:rule context="/nc1initodb:NC1_InitOdb/forces/symbolCode">
      <iso:assert test="if (matches(.,'^APP6B:.[AF].............')) then ../../@situation = 'DQP' else ../../@situation != 'DQP'" diagnostics="D26763-en">NC1_InitOdb.3: la situation doit uniquement valoir « DQP » [COHER. MSG-CTXTE] pour les unités amies sinon elle doit être différente de « DQP ».</iso:assert>
      <iso:assert test="if (../../@situation = 'DQP') then some $Pays in ($L105_2//SimpleCodeList/Row/Value[@ColumnRef='short']/SimpleValue) satisfies substring(.,19,2) = substring($Pays,1,2) and not(matches(substring(.,19,2),'--')) else true()" diagnostics="D26764-en">NC1_InitOdb.5: Le code pays du symbolCode doit être renseigné et sa valeur doit être différente de '--'.</iso:assert>
      <iso:assert test="if (../../@situation = 'DQP') then not(matches(substring(.,17,2),'--')) else true()" diagnostics="D26765-en">NC1_InitOdb.6: Le niveau size mobility du symbolCode doit être renseigné et sa valeur doit être différente de '--'.</iso:assert>
      <iso:assert test="if (../../@situation = 'DQP') then matches(.,'^APP6B:.[AF]') else true()" diagnostics="D26766-en">NC1_InitOdb.7: Le code symbole doit être « ASSUMED FRIEND », ou « FRIEND » (A ou F dans l'APP6B pour le 2nd caractère).</iso:assert>
    </iso:rule>
    <iso:rule context="/nc1initodb:NC1_InitOdb/forces/commandAndControlRole">
      <iso:assert test="if (../../@situation = 'DQP') then . &gt; 1 else true()" diagnostics="D26767-en">NC1_InitOdb.8: L'attribut "commandAndControlRole" ne doit pas avoir les valeurs 'Inconnu' et 'No statement' pour les unités issues des DQP.</iso:assert>
    </iso:rule>
    <iso:rule context="/nc1initodb:NC1_InitOdb/forces">
      <iso:assert test="if (frSpecificSymbol) then some $symbolCode in ($UnitFrSpecific//SimpleCodeList/Row/Value[@ColumnRef='code'][SimpleValue=current()/frSpecificSymbol]/../Value[@ColumnRef='codeSymbole']/SimpleValue) satisfies matches(symbolCode,$symbolCode) else some $symbolCode in ($UnitSymbol//SimpleCodeList/Row/Value[@ColumnRef='codeSymbole']/SimpleValue) satisfies matches(symbolCode,$symbolCode)" diagnostics="D26768-en">NC1_InitOdb.10: Si la spécialisation Fr du code symbole est renseignée alors le code du symbole renseigné doit être celui correspondant à la valeur du dictionnaire des codes symboles spécifiques sinon il doit appartenir à l'une des valeur du dictionnaire des codes symboles autorisés.</iso:assert>
    </iso:rule>
    <iso:rule context="/nc1initodb:NC1_InitOdb/equipmentsHoldings/unitId/@id">
      <iso:assert test="matches(.,'^0:')">NC1_InitOdb.11: Le type de l'objet doit avoir pour valeur 0</iso:assert>
    </iso:rule>
    <iso:rule context="/nc1initodb:NC1_InitOdb/forces/unitId/@id">
      <iso:assert test="matches(.,'^0:')">NC1_InitOdb.11: Le type de l'objet doit avoir pour valeur 0</iso:assert>
    </iso:rule>
    <iso:rule context="/nc1initodb:NC1_InitOdb/resourcesHoldings/unitId/@id">
      <iso:assert test="matches(.,'^0:')">NC1_InitOdb.11: Le type de l'objet doit avoir pour valeur 0</iso:assert>
    </iso:rule>
    <iso:rule context="/nc1initodb:NC1_InitOdb/staffHoldings/unitId/@id">
      <iso:assert test="matches(.,'^0:')">NC1_InitOdb.11: Le type de l'objet doit avoir pour valeur 0</iso:assert>
    </iso:rule>
    <iso:let name="UnitFrSpecific" value="doc('../Dictionnaires/UnitFrSpecificCode.gc')" />
    <iso:let name="L105_2" value="doc('../Dictionnaires/L105_2Code.gc')" />
    <iso:let name="UnitSymbol" value="doc('../Dictionnaires/UnitSymbolCode.gc')" />
  </iso:pattern>
  <iso:diagnostics>
    <iso:diagnostic xml:lang="en" id="D26763-en">NC1_InitOdb.3: "The context shall only be ""DQP"" [COHER. MSG-CTXTE]"</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26764-en">NC1_InitOdb.5: Country Code value for symbolCode must be specified and must be other than '--'.</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26765-en">NC1_InitOdb.6: Size mobility value for symbolCode must be specified and must be other than '--'.</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26766-en">NC1_InitOdb.7: Symbol code must be « ASSUMED FRIEND » or « FRIEND » (A or F in APP6B for 2nd character).</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26767-en">NC1_InitOdb.8: value of the "commandAndControlRole" attribute is prohibited</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26768-en">NC1_InitOdb.10: If the specialization Fr of the symbol code is filled in then the code of the filled in symbol must be the one corresponding to the value of the dictionary of specific symbol codes otherwise it must belong to one of the values ??of the dictionary of authorized symbol codes.</iso:diagnostic>
  </iso:diagnostics>
</iso:schema>
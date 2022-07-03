<?xml version="1.0" encoding="utf-8"?>
<iso:schema queryBinding="xslt2" xmlns:iso="http://purl.oclc.org/dsdl/schematron">
  <!-- NC1 V.9.0.0 -->
  <iso:ns uri="http://www.w3.org/2001/XMLSchema-instance" prefix="xsi" />
  <iso:ns uri="urn:fra:nc1:objet:tacarea" prefix="nc1tacarea" />
  <iso:pattern>
    <iso:title>NC1_TacArea validation rules</iso:title>
    <iso:rule context="/nc1tacarea:NC1_TacArea/tacticalData">
      <iso:assert test="if (frSpecificSymbol) then some $symbolCode in ($TacAreaFrSpecific//SimpleCodeList/Row/Value[@ColumnRef='code'][SimpleValue=current()/frSpecificSymbol]/../Value[@ColumnRef='codeSymbole']/SimpleValue) satisfies matches(symbolCode,$symbolCode) else some $symbolCode in ($TacAreaSymbol//SimpleCodeList/Row/Value[@ColumnRef='codeSymbole']/SimpleValue) satisfies matches(symbolCode,$symbolCode)" diagnostics="D26902-en">NC1_TacArea.1: Si la spécialisation Fr du code symbole est renseignée alors le code du symbole renseigné doit être celui correspondant à la valeur du dictionnaire des codes symboles spécifiques sinon il doit appartenir à l'une des valeurs du dictionnaire des codes symboles autorisés.</iso:assert>
      <iso:assert test="if (frSpecificSymbol) then true() else some $symbolCode in ($TacAreaSymbol//SimpleCodeList/Row/Value[@ColumnRef='code'][SimpleValue&gt;0]/../Value[@ColumnRef='codeSymbole']/SimpleValue) satisfies matches(symbolCode,$symbolCode)">NC1_TacArea.6: Dans le cas ou la spécialisation Fr du code symbole n'est pas renseigné alors le code symbole doit exister et appartenir à l'une des valeurs positives du dictionnaire des codes symbole autorisés.</iso:assert>
    </iso:rule>
    <iso:rule context="/nc1tacarea:NC1_TacArea/tacticalData/symbolCode">
      <iso:assert test="some $Pays in ($L105_2//SimpleCodeList/Row/Value[@ColumnRef='short']/SimpleValue) satisfies substring(.,19,2) = substring($Pays,1,2)" diagnostics="D26900-en">NC1_TacArea.2: Les 13ème et 14ème caractères du Code du symbole doivent correspondre à une valeur du dictionnaire L105_2Code.</iso:assert>
      <iso:assert test="matches(.,':...[AP]')">NC1_TacArea.7: Le 4ème caractère du Code symbole doit correspondre aux valeurs 'A' ou 'P'.</iso:assert>
    </iso:rule>
    <iso:rule context="/nc1tacarea:NC1_TacArea/@id">
      <iso:assert test="matches(.,'^42:')" diagnostics="D26903-en">NC1_TacArea.4: Le type de l'objet doit avoir pour valeur 42.</iso:assert>
    </iso:rule>
    <iso:rule context="/nc1tacarea:NC1_TacArea/tacticalData/responsibleUnitId/@id">
      <iso:assert test="matches(.,'^0:')" diagnostics="D26901-en">NC1_TacArea.5: Le responsable de la surface tactique doit être une unité (NC1_Unit).</iso:assert>
    </iso:rule>
    <iso:let name="TacAreaSymbol" value="doc('../Dictionnaires/TacAreaSymbolCode.gc')" />
    <iso:let name="L105_2" value="doc('../Dictionnaires/L105_2Code.gc')" />
    <iso:let name="TacAreaFrSpecific" value="doc('../Dictionnaires/TacAreaFrSpecificCode.gc')" />
  </iso:pattern>
  <iso:diagnostics>
    <iso:diagnostic xml:lang="en" id="D26900-en">NC1_TacArea.2: The 13th and 14th characters of the Symbol Code must correspond to a value from the L105_2Code dictionary.</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26901-en">NC1_TacArea.5: The responsible of the tactical area shall be a unit (NC1_Unit).</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26902-en">NC1_TacArea.1: If the specialization Fr of the symbol code is filled in then the code of the filled in symbol must be the one corresponding to the value of the dictionary of specific symbol codes otherwise it must belong to one of the values ??of the dictionary of authorized symbol codes.</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26903-en">NC1_TacArea.4: The type of the object has to have for value 42</iso:diagnostic>
  </iso:diagnostics>
</iso:schema>
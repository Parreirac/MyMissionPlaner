<?xml version="1.0" encoding="utf-8"?>
<iso:schema queryBinding="xslt2" xmlns:iso="http://purl.oclc.org/dsdl/schematron">
  <!-- NC1 V.9.0.0 -->
  <iso:ns uri="http://www.w3.org/2001/XMLSchema-instance" prefix="xsi" />
  <iso:ns uri="urn:fra:nc1:objet:tacline" prefix="nc1tacline" />
  <iso:pattern>
    <iso:title>NC1_TacLine validation rules</iso:title>
    <iso:rule context="/nc1tacline:NC1_TacLine/tacticalData">
      <iso:assert test="if (frSpecificSymbol) then some $symbolCode in ($TacLineFrSpecific//SimpleCodeList/Row/Value[@ColumnRef='code'][SimpleValue=current()/frSpecificSymbol]/../Value[@ColumnRef='codeSymbole']/SimpleValue) satisfies matches(symbolCode,$symbolCode) else some $symbolCode in ($TacLineSymbol//SimpleCodeList/Row/Value[@ColumnRef='codeSymbole']/SimpleValue) satisfies matches(symbolCode,$symbolCode)" diagnostics="D26892-en">NC1_TacLine.3: Si la spécialisation Fr du code symbole est renseignée alors le code du symbole renseigné doit être celui correspondant à la valeur du dictionnaire des codes symboles spécifiques sinon il doit appartenir à l'une des valeurs du dictionnaire des codes symboles autorisés.</iso:assert>
      <iso:assert test="if (frSpecificSymbol) then true() else some $symbolCode in ($TacLineSymbol//SimpleCodeList/Row/Value[@ColumnRef='code'][SimpleValue&gt;0]/../Value[@ColumnRef='codeSymbole']/SimpleValue) satisfies matches(symbolCode,$symbolCode)">NC1_TacLine.11: Dans le cas où la spécialisation Fr du code symbole n'est pas renseignée alors le code symbole doit exister et appartenir à l'une des valeurs positives du dictionnaire des codes symboles autorisés.</iso:assert>
    </iso:rule>
    <iso:rule context="/nc1tacline:NC1_TacLine/tacticalData/symbolCode">
      <iso:assert test="some $Pays in ($L105_2//SimpleCodeList/Row/Value[@ColumnRef='short']/SimpleValue) satisfies substring(.,19,2) = substring($Pays,1,2)" diagnostics="D26898-en">NC1_TacLine.4: Les 13ème et 14ème caractères du Code du symbole doivent correspondre à une valeur du dictionnaire L105_2Code.</iso:assert>
      <iso:assert test="if (matches(., ':G.C.MGLB')) then (../../specificData/leftUnitId or ../../specificData/rightUnitId) else true()" diagnostics="D26893-en">NC1_TacLine.7: Si la ligne tactique est une limite entre unités, l'unité à gauche ou l'unité à droite de la limite doit être renseignée sinon aucune ne doit être renseignée.</iso:assert>
      <iso:assert test="matches(.,':...[AP]')">NC1_TacLine.12: Le 4ème caractère du Code symbole doit correspondre aux valeurs 'A' ou 'P'.</iso:assert>
    </iso:rule>
    <iso:rule context="/nc1tacline:NC1_TacLine/@id">
      <iso:assert test="matches(.,'^41:')" diagnostics="D26897-en">NC1_TacLine.6: Le type de l'objet doit avoir pour valeur 41</iso:assert>
    </iso:rule>
    <iso:rule context="/nc1tacline:NC1_TacLine/specificData/leftUnitId/@id">
      <iso:assert test="matches(.,'^0:')" diagnostics="D26894-en">NC1_TacLine.8: L'unité à gauche de la limite doit être une unité (NC1_Unit).</iso:assert>
    </iso:rule>
    <iso:rule context="/nc1tacline:NC1_TacLine/specificData/rightUnitId/@id">
      <iso:assert test="matches(.,'^0:')" diagnostics="D26895-en">NC1_TacLine.8: L'unité à droite de la limite doit être une unité (NC1_Unit).</iso:assert>
    </iso:rule>
    <iso:rule context="/nc1tacline:NC1_TacLine/tacticalData/responsibleUnitId/@id">
      <iso:assert test="matches(.,'^0:')" diagnostics="D26896-en">NC1_TacLine.9: Le responsable de la ligne tactique doit être une unité (NC1_Unit).</iso:assert>
    </iso:rule>
    <iso:rule context="/nc1tacline:NC1_TacLine/location/multipoint">
      <iso:assert test="count(point) = 2" diagnostics="D26899-en">NC1_TacLine.10: Le nombre de points pour la localisation de type multipoint est de 2 points.</iso:assert>
    </iso:rule>
    <iso:let name="TacLineSymbol" value="doc('../Dictionnaires/TacLineSymbolCode.gc')" />
    <iso:let name="L105_2" value="doc('../Dictionnaires/L105_2Code.gc')" />
    <iso:let name="TacLineFrSpecific" value="doc('../Dictionnaires/TacLineFrSpecificCode.gc')" />
  </iso:pattern>
  <iso:diagnostics>
    <iso:diagnostic xml:lang="en" id="D26892-en">NC1_TacLine.3: If the specialization Fr of the symbol code is filled in then the code of the filled in symbol must be the one corresponding to the value of the dictionary of specific symbol codes otherwise it must belong to one of the values ??of the dictionary of authorized symbol codes.</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26893-en">NC1_TacLine.7: If the tactical line is a limit between units, unit to the left or unit to the right of the limit shall be provided else none must be provided.</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26894-en">NC1_TacLine.8: The unit to the left of the limit shall be a unit (NC1_Unit).</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26895-en">NC1_TacLine.8: The unit to the right of the limit shall be a unit (NC1_Unit).</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26896-en">NC1_TacLine.9: The responsible of the tactical line shall be a unit (NC1_Unit).</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26897-en">NC1_TacLine.6: The type of the object has to have for value 41</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26898-en">NC1_TacLine.4: The 13th and 14th characters of the Symbol Code must correspond to a value from the L105_2Code dictionary.</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26899-en">NC1_TacLine.10: The number of points for multipoint type localization is 2 points.</iso:diagnostic>
  </iso:diagnostics>
</iso:schema>
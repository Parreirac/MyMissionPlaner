<?xml version="1.0" encoding="utf-8"?>
<iso:schema queryBinding="xslt2" xmlns:iso="http://purl.oclc.org/dsdl/schematron">
  <!-- NC1 V.9.0.0 -->
  <iso:ns uri="http://www.w3.org/2001/XMLSchema-instance" prefix="xsi" />
  <iso:ns uri="urn:fra:nc1:objet:cbrnevent" prefix="nc1cbrnevent" />
  <iso:pattern>
    <iso:title>NC1_CbrnEvent validation rules</iso:title>
    <iso:rule context="/nc1cbrnevent:NC1_CbrnEvent/tacticalData/symbolCode">
      <iso:assert test="matches(., '^APP6B:G.C.BW[^D]')" diagnostics="D26794-en">NC1_CbrnEvent.2: Le standard de symbologie utilisé doit être l'APP-6(B). Le code symbole d'un événement NRBC doit être dans la famille G*C*BW********* mais pas dans la famille G*C*BWD********</iso:assert>
      <iso:assert test="some $Pays in ($L105_2//SimpleCodeList/Row/Value[@ColumnRef='short']/SimpleValue) satisfies substring(.,19,2) = substring($Pays,1,2)" diagnostics="D26796-en">NC1_CbrnEvent.3: Les 13ème et 14ème caractères du Code du symbole doivent correspondre à une valeur du dictionnaire L105_2Code.</iso:assert>
      <iso:assert test="matches(.,':...[AP]')">NC1_CbrnEvent.6: Le 4ème caractère du Code symbole doit correspondre aux valeurs 'A' ou 'P'.</iso:assert>
    </iso:rule>
    <iso:rule context="/nc1cbrnevent:NC1_CbrnEvent/@id">
      <iso:assert test="matches(.,'^31:')" diagnostics="D26795-en">NC1_CbrnEvent.5: Le type de l'objet doit avoir pour valeur 31</iso:assert>
    </iso:rule>
    <iso:let name="L105_2" value="doc('../Dictionnaires/L105_2Code.gc')" />
  </iso:pattern>
  <iso:diagnostics>
    <iso:diagnostic xml:lang="en" id="D26794-en">NC1_CbrnEvent.2: The symbol code of a CBRN event shall be of the following type:  G*C*BW********* .</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26795-en">NC1_CbrnEvent.5: The type of the object has to have for value 31</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26796-en">NC1_CbrnEvent.3: The 13th and 14th characters of the Symbol Code must correspond to a value from the L105_2Code dictionary.</iso:diagnostic>
  </iso:diagnostics>
</iso:schema>
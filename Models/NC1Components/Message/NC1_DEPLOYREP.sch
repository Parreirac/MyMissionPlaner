<?xml version="1.0" encoding="utf-8"?>
<iso:schema queryBinding="xslt2" xmlns:iso="http://purl.oclc.org/dsdl/schematron">
  <!-- NC1 V.9.0.0 -->
  <iso:ns uri="http://www.w3.org/2001/XMLSchema-instance" prefix="xsi" />
  <iso:ns uri="urn:fra:nc1:message:deployrep" prefix="nc1deployrep" />
  <iso:pattern>
    <iso:title>NC1_DEPLOYREP validation rules</iso:title>
    <iso:rule context="/nc1deployrep:NC1_DEPLOYREP/deployment/finalLocalizedUnit">
      <iso:assert test="count(location) = 1" diagnostics="D26459-en">NC1_DEPLOYREP.1: La localisation prévue des unités en fin de déploiement doit être renseignée.</iso:assert>
    </iso:rule>
    <iso:rule context="/nc1deployrep:NC1_DEPLOYREP/deployment/localizedUnit">
      <iso:assert test="count(location) = 1" diagnostics="D26458-en">NC1_DEPLOYREP.1: La localisation actuelle des unités doit être renseignée. </iso:assert>
    </iso:rule>
    <iso:rule context="/nc1deployrep:NC1_DEPLOYREP/deployment/startPoint/tacticalData/symbolCode">
      <iso:assert test="matches(.,':G.C.OGI---')" diagnostics="D26460-en">NC1_DEPLOYREP.2: Le code symbole du point de départ du déploiement doit être dans la famille G*C*OGI---***** (START POINT).</iso:assert>
      <iso:assert test="some $Pays in ($L105_2//SimpleCodeList/Row/Value[@ColumnRef='short']/SimpleValue) satisfies substring(.,19,2) = substring($Pays,1,2)" diagnostics="D26832-en">NC1_TacPoint.2: Les 13ème et 14ème caractères du Code du symbole doivent correspondre à une valeur du dictionnaire L105_2Code.</iso:assert>
      <iso:assert test="matches(.,':...[AP]')">NC1_TacPoint.7: Le 4ème caractère du Code symbole doit correspondre aux valeurs 'A' ou 'P'.</iso:assert>
    </iso:rule>
    <iso:rule context="/nc1deployrep:NC1_DEPLOYREP/deployment/endPoint/tacticalData/symbolCode">
      <iso:assert test="matches(.,':G.C.OGS---')" diagnostics="D26461-en">NC1_DEPLOYREP.3: Le code symbole du point de dislocation du déploiement doit être dans la famille G*C*OGS---***** (RELEASE POINT).</iso:assert>
      <iso:assert test="some $Pays in ($L105_2//SimpleCodeList/Row/Value[@ColumnRef='short']/SimpleValue) satisfies substring(.,19,2) = substring($Pays,1,2)" diagnostics="D26832-en">NC1_TacPoint.2: Les 13ème et 14ème caractères du Code du symbole doivent correspondre à une valeur du dictionnaire L105_2Code.</iso:assert>
      <iso:assert test="matches(.,':...[AP]')">NC1_TacPoint.7: Le 4ème caractère du Code symbole doit correspondre aux valeurs 'A' ou 'P'.</iso:assert>
    </iso:rule>
    <iso:rule context="/nc1deployrep:NC1_DEPLOYREP/deployment/localizedUnit/tacticalData">
      <iso:assert test="if (frSpecificSymbol) then some $symbolCode in ($UnitFrSpecific//SimpleCodeList/Row/Value[@ColumnRef='code'][SimpleValue=current()/frSpecificSymbol]/../Value[@ColumnRef='codeSymbole']/SimpleValue) satisfies matches(symbolCode,$symbolCode) else some $symbolCode in ($UnitSymbol//SimpleCodeList/Row/Value[@ColumnRef='codeSymbole']/SimpleValue) satisfies matches(symbolCode,$symbolCode)" diagnostics="D26869-en">NC1_Unit.2: Si la spécialisation Fr du code symbole est renseignée alors le code du symbole renseigné doit être celui correspondant à la valeur du dictionnaire des codes symboles spécifiques sinon il doit appartenir à l'une des valeur du dictionnaire des codes symboles autorisés.</iso:assert>
      <iso:assert test="if (matches(symbolCode,':.[AF]')) then count(eisn) + count(tnl16) = 0 else count(urn) + count(stnl16) = 0" diagnostics="D26871-en">NC1_Unit.8: Pour une unité non amie, les identifiants URN et STNL16 ne doivent pas être renseignés et pour une unité amie, les identifiants EISN et TNL16 ne doivent pas être renseignés.</iso:assert>
      <iso:assert test="if (frSpecificSymbol) then true() else some $symbolCode in ($UnitSymbol//SimpleCodeList/Row/Value[@ColumnRef='code'][SimpleValue&gt;0]/../Value[@ColumnRef='codeSymbole']/SimpleValue) satisfies matches(symbolCode,$symbolCode)">NC1_Unit.23: Dans le cas où la spécialisation Fr du code symbole n'est pas renseignée alors le code symbole doit exister et appartenir à l'une des valeurs positives du dictionnaire des codes symboles autorisés.</iso:assert>
    </iso:rule>
    <iso:rule context="/nc1deployrep:NC1_DEPLOYREP/deployment/localizedUnit/tacticalData/symbolCode">
      <iso:assert test="some $Pays in ($L105_2//SimpleCodeList/Row/Value[@ColumnRef='short']/SimpleValue) satisfies substring(.,19,2) = substring($Pays,1,2)" diagnostics="D26863-en">NC1_Unit.3: Les 13ème et 14ème caractères du Code du symbole doivent correspondre à une valeur du dictionnaire L105_2Code.</iso:assert>
      <iso:assert test="if (matches(.,':...A')) then count(../../location/datetime) + count(../../location/quality) = 0 else true()" diagnostics="D26864-en">NC1_Unit.9: Lorsque l'unité est anticipée, la qualité de la mesure de localisation et l'horodatage du relevé de sa position sur le terrain ne doivent pas être renseignés.</iso:assert>
      <iso:assert test="if (matches(.,':.[SHJK]')) then (matches(../../location/quality,'1') or not(../../location/quality)) else true()" diagnostics="D26870-en">NC1_Unit.16: La localisation d'une unité ennemie ne peut qu'être estimée.</iso:assert>
      <iso:assert test="matches(.,':...[AP]')">NC1_Unit.24: Le 4ème caractère du Code symbole doit correspondre aux valeurs 'A' ou 'P'.</iso:assert>
    </iso:rule>
    <iso:rule context="/nc1deployrep:NC1_DEPLOYREP/deployment/localizedUnit/@id">
      <iso:assert test="matches(.,'^0:')" diagnostics="D26872-en">NC1_Unit.7: Le type de l'objet doit avoir pour valeur 0</iso:assert>
    </iso:rule>
    <iso:rule context="/nc1deployrep:NC1_DEPLOYREP/deployment/localizedUnit/tacticalData/subordination/subordinationType">
      <iso:assert test="if (.=5) then not(../detachmentPeriod) else ../detachmentPeriod" diagnostics="D26865-en">NC1_Unit.12: Pour un lien de subordination organique, i.e. égal à 5 (RATORG), la période de détachement ne doit pas être renseignée sinon cette période de détachement doit être renseignée.</iso:assert>
      <iso:assert test="../superiorUnitId" diagnostics="D26866-en">NC1_Unit.13: Lorsque le type de subordination est renseigné, le supérieur doit également être renseigné.</iso:assert>
    </iso:rule>
    <iso:rule context="/nc1deployrep:NC1_DEPLOYREP/deployment/localizedUnit/tacticalData/subordination/superiorUnitId/@id">
      <iso:assert test="matches(.,'^0:')" diagnostics="D26867-en">NC1_Unit.14: Le supérieur de l'unité doit également être une unité (NC1_Unit).</iso:assert>
    </iso:rule>
    <iso:rule context="/nc1deployrep:NC1_DEPLOYREP/deployment/localizedUnit/status">
      <iso:assert test="logisticStatus or operationalStatus" diagnostics="D26868-en">NC1_Unit.15: L'état opérationnel ou l'état logistique de l'unité doit être renseigné.</iso:assert>
    </iso:rule>
    <iso:rule context="/nc1deployrep:NC1_DEPLOYREP/deployment/localizedUnit/status/operationalStatus">
      <iso:assert test="effectif or personnelTiredness or equipment or fuel or ammunitions">NC1_Unit.15: L'effectif ou l'état de fatigue ou l'état matériel ou l'état carburant ou l'état munitions doit être renseigné.</iso:assert>
    </iso:rule>
    <iso:rule context="/nc1deployrep:NC1_DEPLOYREP/deployment/localizedUnit/tacticalData/commandAndControlRole">
      <iso:assert test="if (matches(../../@id,':0:')) then . &gt; 1 else true()" diagnostics="D26873-en">NC1_Unit.19: L'attribut "commandAndControlRole" ne doit pas avoir les valeurs 'Inconnu' et 'No statement' pour les unités issues des DQP.</iso:assert>
    </iso:rule>
    <iso:rule context="/nc1deployrep:NC1_DEPLOYREP/deployment/startPoint/tacticalData">
      <iso:assert test="if (frSpecificSymbol) then some $symbolCode in ($TacPointFrSpecific//SimpleCodeList/Row/Value[@ColumnRef='code'][SimpleValue=current()/frSpecificSymbol]/../Value[@ColumnRef='codeSymbole']/SimpleValue) satisfies matches(symbolCode,$symbolCode) else some $symbolCode in ($TacPointSymbol//SimpleCodeList/Row/Value[@ColumnRef='codeSymbole']/SimpleValue) satisfies matches(symbolCode,$symbolCode)" diagnostics="D26830-en">NC1_TacPoint.1: Si la spécialisation Fr du code symbole est renseignée alors le code du symbole renseigné doit être celui correspondant à la valeur du dictionnaire des codes symboles spécifiques sinon il doit appartenir à l'une des valeurs du dictionnaire des codes symboles autorisés.</iso:assert>
      <iso:assert test="if (frSpecificSymbol) then true() else some $symbolCode in ($TacPointSymbol//SimpleCodeList/Row/Value[@ColumnRef='code'][SimpleValue&gt;0]/../Value[@ColumnRef='codeSymbole']/SimpleValue) satisfies matches(symbolCode,$symbolCode)">NC1_TacPoint.6: Dans le cas où la spécialisation Fr du code symbole n'est pas renseignée alors le code symbole doit exister et appartenir à l'une des valeurs positives du dictionnaire des codes symboles autorisés.</iso:assert>
    </iso:rule>
    <iso:rule context="/nc1deployrep:NC1_DEPLOYREP/deployment/startPoint/@id">
      <iso:assert test="matches(.,'^40:')" diagnostics="D26831-en">NC1_TacPoint.4: Le type de l'objet doit avoir pour valeur 40</iso:assert>
    </iso:rule>
    <iso:rule context="/nc1deployrep:NC1_DEPLOYREP/deployment/startPoint/tacticalData/responsibleUnitId/@id">
      <iso:assert test="matches(.,'^0:')" diagnostics="D26829-en">NC1_TacPoint.5: Le responsable du point tactique doit être une unité (NC1_Unit).</iso:assert>
    </iso:rule>
    <iso:rule context="/nc1deployrep:NC1_DEPLOYREP/deployment/startPocUnit/tacticalData">
      <iso:assert test="if (frSpecificSymbol) then some $symbolCode in ($UnitFrSpecific//SimpleCodeList/Row/Value[@ColumnRef='code'][SimpleValue=current()/frSpecificSymbol]/../Value[@ColumnRef='codeSymbole']/SimpleValue) satisfies matches(symbolCode,$symbolCode) else some $symbolCode in ($UnitSymbol//SimpleCodeList/Row/Value[@ColumnRef='codeSymbole']/SimpleValue) satisfies matches(symbolCode,$symbolCode)" diagnostics="D26869-en">NC1_Unit.2: Si la spécialisation Fr du code symbole est renseignée alors le code du symbole renseigné doit être celui correspondant à la valeur du dictionnaire des codes symboles spécifiques sinon il doit appartenir à l'une des valeur du dictionnaire des codes symboles autorisés.</iso:assert>
      <iso:assert test="if (matches(symbolCode,':.[AF]')) then count(eisn) + count(tnl16) = 0 else count(urn) + count(stnl16) = 0" diagnostics="D26871-en">NC1_Unit.8: Pour une unité non amie, les identifiants URN et STNL16 ne doivent pas être renseignés et pour une unité amie, les identifiants EISN et TNL16 ne doivent pas être renseignés.</iso:assert>
      <iso:assert test="if (frSpecificSymbol) then true() else some $symbolCode in ($UnitSymbol//SimpleCodeList/Row/Value[@ColumnRef='code'][SimpleValue&gt;0]/../Value[@ColumnRef='codeSymbole']/SimpleValue) satisfies matches(symbolCode,$symbolCode)">NC1_Unit.23: Dans le cas où la spécialisation Fr du code symbole n'est pas renseignée alors le code symbole doit exister et appartenir à l'une des valeurs positives du dictionnaire des codes symboles autorisés.</iso:assert>
    </iso:rule>
    <iso:rule context="/nc1deployrep:NC1_DEPLOYREP/deployment/startPocUnit/tacticalData/symbolCode">
      <iso:assert test="some $Pays in ($L105_2//SimpleCodeList/Row/Value[@ColumnRef='short']/SimpleValue) satisfies substring(.,19,2) = substring($Pays,1,2)" diagnostics="D26863-en">NC1_Unit.3: Les 13ème et 14ème caractères du Code du symbole doivent correspondre à une valeur du dictionnaire L105_2Code.</iso:assert>
      <iso:assert test="if (matches(.,':...A')) then count(../../location/datetime) + count(../../location/quality) = 0 else true()" diagnostics="D26864-en">NC1_Unit.9: Lorsque l'unité est anticipée, la qualité de la mesure de localisation et l'horodatage du relevé de sa position sur le terrain ne doivent pas être renseignés.</iso:assert>
      <iso:assert test="if (matches(.,':.[SHJK]')) then (matches(../../location/quality,'1') or not(../../location/quality)) else true()" diagnostics="D26870-en">NC1_Unit.16: La localisation d'une unité ennemie ne peut qu'être estimée.</iso:assert>
      <iso:assert test="matches(.,':...[AP]')">NC1_Unit.24: Le 4ème caractère du Code symbole doit correspondre aux valeurs 'A' ou 'P'.</iso:assert>
    </iso:rule>
    <iso:rule context="/nc1deployrep:NC1_DEPLOYREP/deployment/startPocUnit/@id">
      <iso:assert test="matches(.,'^0:')" diagnostics="D26872-en">NC1_Unit.7: Le type de l'objet doit avoir pour valeur 0</iso:assert>
    </iso:rule>
    <iso:rule context="/nc1deployrep:NC1_DEPLOYREP/deployment/startPocUnit/tacticalData/subordination/subordinationType">
      <iso:assert test="if (.=5) then not(../detachmentPeriod) else ../detachmentPeriod" diagnostics="D26865-en">NC1_Unit.12: Pour un lien de subordination organique, i.e. égal à 5 (RATORG), la période de détachement ne doit pas être renseignée sinon cette période de détachement doit être renseignée.</iso:assert>
      <iso:assert test="../superiorUnitId" diagnostics="D26866-en">NC1_Unit.13: Lorsque le type de subordination est renseigné, le supérieur doit également être renseigné.</iso:assert>
    </iso:rule>
    <iso:rule context="/nc1deployrep:NC1_DEPLOYREP/deployment/startPocUnit/tacticalData/subordination/superiorUnitId/@id">
      <iso:assert test="matches(.,'^0:')" diagnostics="D26867-en">NC1_Unit.14: Le supérieur de l'unité doit également être une unité (NC1_Unit).</iso:assert>
    </iso:rule>
    <iso:rule context="/nc1deployrep:NC1_DEPLOYREP/deployment/startPocUnit/status">
      <iso:assert test="logisticStatus or operationalStatus" diagnostics="D26868-en">NC1_Unit.15: L'état opérationnel ou l'état logistique de l'unité doit être renseigné.</iso:assert>
    </iso:rule>
    <iso:rule context="/nc1deployrep:NC1_DEPLOYREP/deployment/startPocUnit/status/operationalStatus">
      <iso:assert test="effectif or personnelTiredness or equipment or fuel or ammunitions">NC1_Unit.15: L'effectif ou l'état de fatigue ou l'état matériel ou l'état carburant ou l'état munitions doit être renseigné.</iso:assert>
    </iso:rule>
    <iso:rule context="/nc1deployrep:NC1_DEPLOYREP/deployment/startPocUnit/tacticalData/commandAndControlRole">
      <iso:assert test="if (matches(../../@id,':0:')) then . &gt; 1 else true()" diagnostics="D26873-en">NC1_Unit.19: L'attribut "commandAndControlRole" ne doit pas avoir les valeurs 'Inconnu' et 'No statement' pour les unités issues des DQP.</iso:assert>
    </iso:rule>
    <iso:rule context="/nc1deployrep:NC1_DEPLOYREP/deployment/endPoint/tacticalData">
      <iso:assert test="if (frSpecificSymbol) then some $symbolCode in ($TacPointFrSpecific//SimpleCodeList/Row/Value[@ColumnRef='code'][SimpleValue=current()/frSpecificSymbol]/../Value[@ColumnRef='codeSymbole']/SimpleValue) satisfies matches(symbolCode,$symbolCode) else some $symbolCode in ($TacPointSymbol//SimpleCodeList/Row/Value[@ColumnRef='codeSymbole']/SimpleValue) satisfies matches(symbolCode,$symbolCode)" diagnostics="D26830-en">NC1_TacPoint.1: Si la spécialisation Fr du code symbole est renseignée alors le code du symbole renseigné doit être celui correspondant à la valeur du dictionnaire des codes symboles spécifiques sinon il doit appartenir à l'une des valeurs du dictionnaire des codes symboles autorisés.</iso:assert>
      <iso:assert test="if (frSpecificSymbol) then true() else some $symbolCode in ($TacPointSymbol//SimpleCodeList/Row/Value[@ColumnRef='code'][SimpleValue&gt;0]/../Value[@ColumnRef='codeSymbole']/SimpleValue) satisfies matches(symbolCode,$symbolCode)">NC1_TacPoint.6: Dans le cas où la spécialisation Fr du code symbole n'est pas renseignée alors le code symbole doit exister et appartenir à l'une des valeurs positives du dictionnaire des codes symboles autorisés.</iso:assert>
    </iso:rule>
    <iso:rule context="/nc1deployrep:NC1_DEPLOYREP/deployment/endPoint/@id">
      <iso:assert test="matches(.,'^40:')" diagnostics="D26831-en">NC1_TacPoint.4: Le type de l'objet doit avoir pour valeur 40</iso:assert>
    </iso:rule>
    <iso:rule context="/nc1deployrep:NC1_DEPLOYREP/deployment/endPoint/tacticalData/responsibleUnitId/@id">
      <iso:assert test="matches(.,'^0:')" diagnostics="D26829-en">NC1_TacPoint.5: Le responsable du point tactique doit être une unité (NC1_Unit).</iso:assert>
    </iso:rule>
    <iso:rule context="/nc1deployrep:NC1_DEPLOYREP/deployment/endPocUnit/tacticalData">
      <iso:assert test="if (frSpecificSymbol) then some $symbolCode in ($UnitFrSpecific//SimpleCodeList/Row/Value[@ColumnRef='code'][SimpleValue=current()/frSpecificSymbol]/../Value[@ColumnRef='codeSymbole']/SimpleValue) satisfies matches(symbolCode,$symbolCode) else some $symbolCode in ($UnitSymbol//SimpleCodeList/Row/Value[@ColumnRef='codeSymbole']/SimpleValue) satisfies matches(symbolCode,$symbolCode)" diagnostics="D26869-en">NC1_Unit.2: Si la spécialisation Fr du code symbole est renseignée alors le code du symbole renseigné doit être celui correspondant à la valeur du dictionnaire des codes symboles spécifiques sinon il doit appartenir à l'une des valeur du dictionnaire des codes symboles autorisés.</iso:assert>
      <iso:assert test="if (matches(symbolCode,':.[AF]')) then count(eisn) + count(tnl16) = 0 else count(urn) + count(stnl16) = 0" diagnostics="D26871-en">NC1_Unit.8: Pour une unité non amie, les identifiants URN et STNL16 ne doivent pas être renseignés et pour une unité amie, les identifiants EISN et TNL16 ne doivent pas être renseignés.</iso:assert>
      <iso:assert test="if (frSpecificSymbol) then true() else some $symbolCode in ($UnitSymbol//SimpleCodeList/Row/Value[@ColumnRef='code'][SimpleValue&gt;0]/../Value[@ColumnRef='codeSymbole']/SimpleValue) satisfies matches(symbolCode,$symbolCode)">NC1_Unit.23: Dans le cas où la spécialisation Fr du code symbole n'est pas renseignée alors le code symbole doit exister et appartenir à l'une des valeurs positives du dictionnaire des codes symboles autorisés.</iso:assert>
    </iso:rule>
    <iso:rule context="/nc1deployrep:NC1_DEPLOYREP/deployment/endPocUnit/tacticalData/symbolCode">
      <iso:assert test="some $Pays in ($L105_2//SimpleCodeList/Row/Value[@ColumnRef='short']/SimpleValue) satisfies substring(.,19,2) = substring($Pays,1,2)" diagnostics="D26863-en">NC1_Unit.3: Les 13ème et 14ème caractères du Code du symbole doivent correspondre à une valeur du dictionnaire L105_2Code.</iso:assert>
      <iso:assert test="if (matches(.,':...A')) then count(../../location/datetime) + count(../../location/quality) = 0 else true()" diagnostics="D26864-en">NC1_Unit.9: Lorsque l'unité est anticipée, la qualité de la mesure de localisation et l'horodatage du relevé de sa position sur le terrain ne doivent pas être renseignés.</iso:assert>
      <iso:assert test="if (matches(.,':.[SHJK]')) then (matches(../../location/quality,'1') or not(../../location/quality)) else true()" diagnostics="D26870-en">NC1_Unit.16: La localisation d'une unité ennemie ne peut qu'être estimée.</iso:assert>
      <iso:assert test="matches(.,':...[AP]')">NC1_Unit.24: Le 4ème caractère du Code symbole doit correspondre aux valeurs 'A' ou 'P'.</iso:assert>
    </iso:rule>
    <iso:rule context="/nc1deployrep:NC1_DEPLOYREP/deployment/endPocUnit/@id">
      <iso:assert test="matches(.,'^0:')" diagnostics="D26872-en">NC1_Unit.7: Le type de l'objet doit avoir pour valeur 0</iso:assert>
    </iso:rule>
    <iso:rule context="/nc1deployrep:NC1_DEPLOYREP/deployment/endPocUnit/tacticalData/subordination/subordinationType">
      <iso:assert test="if (.=5) then not(../detachmentPeriod) else ../detachmentPeriod" diagnostics="D26865-en">NC1_Unit.12: Pour un lien de subordination organique, i.e. égal à 5 (RATORG), la période de détachement ne doit pas être renseignée sinon cette période de détachement doit être renseignée.</iso:assert>
      <iso:assert test="../superiorUnitId" diagnostics="D26866-en">NC1_Unit.13: Lorsque le type de subordination est renseigné, le supérieur doit également être renseigné.</iso:assert>
    </iso:rule>
    <iso:rule context="/nc1deployrep:NC1_DEPLOYREP/deployment/endPocUnit/tacticalData/subordination/superiorUnitId/@id">
      <iso:assert test="matches(.,'^0:')" diagnostics="D26867-en">NC1_Unit.14: Le supérieur de l'unité doit également être une unité (NC1_Unit).</iso:assert>
    </iso:rule>
    <iso:rule context="/nc1deployrep:NC1_DEPLOYREP/deployment/endPocUnit/status">
      <iso:assert test="logisticStatus or operationalStatus" diagnostics="D26868-en">NC1_Unit.15: L'état opérationnel ou l'état logistique de l'unité doit être renseigné.</iso:assert>
    </iso:rule>
    <iso:rule context="/nc1deployrep:NC1_DEPLOYREP/deployment/endPocUnit/status/operationalStatus">
      <iso:assert test="effectif or personnelTiredness or equipment or fuel or ammunitions">NC1_Unit.15: L'effectif ou l'état de fatigue ou l'état matériel ou l'état carburant ou l'état munitions doit être renseigné.</iso:assert>
    </iso:rule>
    <iso:rule context="/nc1deployrep:NC1_DEPLOYREP/deployment/endPocUnit/tacticalData/commandAndControlRole">
      <iso:assert test="if (matches(../../@id,':0:')) then . &gt; 1 else true()" diagnostics="D26873-en">NC1_Unit.19: L'attribut "commandAndControlRole" ne doit pas avoir les valeurs 'Inconnu' et 'No statement' pour les unités issues des DQP.</iso:assert>
    </iso:rule>
    <iso:rule context="/nc1deployrep:NC1_DEPLOYREP/deployment/finalLocalizedUnit/tacticalData">
      <iso:assert test="if (frSpecificSymbol) then some $symbolCode in ($UnitFrSpecific//SimpleCodeList/Row/Value[@ColumnRef='code'][SimpleValue=current()/frSpecificSymbol]/../Value[@ColumnRef='codeSymbole']/SimpleValue) satisfies matches(symbolCode,$symbolCode) else some $symbolCode in ($UnitSymbol//SimpleCodeList/Row/Value[@ColumnRef='codeSymbole']/SimpleValue) satisfies matches(symbolCode,$symbolCode)" diagnostics="D26869-en">NC1_Unit.2: Si la spécialisation Fr du code symbole est renseignée alors le code du symbole renseigné doit être celui correspondant à la valeur du dictionnaire des codes symboles spécifiques sinon il doit appartenir à l'une des valeur du dictionnaire des codes symboles autorisés.</iso:assert>
      <iso:assert test="if (matches(symbolCode,':.[AF]')) then count(eisn) + count(tnl16) = 0 else count(urn) + count(stnl16) = 0" diagnostics="D26871-en">NC1_Unit.8: Pour une unité non amie, les identifiants URN et STNL16 ne doivent pas être renseignés et pour une unité amie, les identifiants EISN et TNL16 ne doivent pas être renseignés.</iso:assert>
      <iso:assert test="if (frSpecificSymbol) then true() else some $symbolCode in ($UnitSymbol//SimpleCodeList/Row/Value[@ColumnRef='code'][SimpleValue&gt;0]/../Value[@ColumnRef='codeSymbole']/SimpleValue) satisfies matches(symbolCode,$symbolCode)">NC1_Unit.23: Dans le cas où la spécialisation Fr du code symbole n'est pas renseignée alors le code symbole doit exister et appartenir à l'une des valeurs positives du dictionnaire des codes symboles autorisés.</iso:assert>
    </iso:rule>
    <iso:rule context="/nc1deployrep:NC1_DEPLOYREP/deployment/finalLocalizedUnit/tacticalData/symbolCode">
      <iso:assert test="some $Pays in ($L105_2//SimpleCodeList/Row/Value[@ColumnRef='short']/SimpleValue) satisfies substring(.,19,2) = substring($Pays,1,2)" diagnostics="D26863-en">NC1_Unit.3: Les 13ème et 14ème caractères du Code du symbole doivent correspondre à une valeur du dictionnaire L105_2Code.</iso:assert>
      <iso:assert test="if (matches(.,':...A')) then count(../../location/datetime) + count(../../location/quality) = 0 else true()" diagnostics="D26864-en">NC1_Unit.9: Lorsque l'unité est anticipée, la qualité de la mesure de localisation et l'horodatage du relevé de sa position sur le terrain ne doivent pas être renseignés.</iso:assert>
      <iso:assert test="if (matches(.,':.[SHJK]')) then (matches(../../location/quality,'1') or not(../../location/quality)) else true()" diagnostics="D26870-en">NC1_Unit.16: La localisation d'une unité ennemie ne peut qu'être estimée.</iso:assert>
      <iso:assert test="matches(.,':...[AP]')">NC1_Unit.24: Le 4ème caractère du Code symbole doit correspondre aux valeurs 'A' ou 'P'.</iso:assert>
    </iso:rule>
    <iso:rule context="/nc1deployrep:NC1_DEPLOYREP/deployment/finalLocalizedUnit/@id">
      <iso:assert test="matches(.,'^0:')" diagnostics="D26872-en">NC1_Unit.7: Le type de l'objet doit avoir pour valeur 0</iso:assert>
    </iso:rule>
    <iso:rule context="/nc1deployrep:NC1_DEPLOYREP/deployment/finalLocalizedUnit/tacticalData/subordination/subordinationType">
      <iso:assert test="if (.=5) then not(../detachmentPeriod) else ../detachmentPeriod" diagnostics="D26865-en">NC1_Unit.12: Pour un lien de subordination organique, i.e. égal à 5 (RATORG), la période de détachement ne doit pas être renseignée sinon cette période de détachement doit être renseignée.</iso:assert>
      <iso:assert test="../superiorUnitId" diagnostics="D26866-en">NC1_Unit.13: Lorsque le type de subordination est renseigné, le supérieur doit également être renseigné.</iso:assert>
    </iso:rule>
    <iso:rule context="/nc1deployrep:NC1_DEPLOYREP/deployment/finalLocalizedUnit/tacticalData/subordination/superiorUnitId/@id">
      <iso:assert test="matches(.,'^0:')" diagnostics="D26867-en">NC1_Unit.14: Le supérieur de l'unité doit également être une unité (NC1_Unit).</iso:assert>
    </iso:rule>
    <iso:rule context="/nc1deployrep:NC1_DEPLOYREP/deployment/finalLocalizedUnit/status">
      <iso:assert test="logisticStatus or operationalStatus" diagnostics="D26868-en">NC1_Unit.15: L'état opérationnel ou l'état logistique de l'unité doit être renseigné.</iso:assert>
    </iso:rule>
    <iso:rule context="/nc1deployrep:NC1_DEPLOYREP/deployment/finalLocalizedUnit/status/operationalStatus">
      <iso:assert test="effectif or personnelTiredness or equipment or fuel or ammunitions">NC1_Unit.15: L'effectif ou l'état de fatigue ou l'état matériel ou l'état carburant ou l'état munitions doit être renseigné.</iso:assert>
    </iso:rule>
    <iso:rule context="/nc1deployrep:NC1_DEPLOYREP/deployment/finalLocalizedUnit/tacticalData/commandAndControlRole">
      <iso:assert test="if (matches(../../@id,':0:')) then . &gt; 1 else true()" diagnostics="D26873-en">NC1_Unit.19: L'attribut "commandAndControlRole" ne doit pas avoir les valeurs 'Inconnu' et 'No statement' pour les unités issues des DQP.</iso:assert>
    </iso:rule>
    <iso:let name="UnitFrSpecific" value="doc('../Dictionnaires/UnitFrSpecificCode.gc')" />
    <iso:let name="L105_2" value="doc('../Dictionnaires/L105_2Code.gc')" />
    <iso:let name="UnitSymbol" value="doc('../Dictionnaires/UnitSymbolCode.gc')" />
    <iso:let name="TacPointSymbol" value="doc('../Dictionnaires/TacPointSymbolCode.gc')" />
    <iso:let name="TacPointFrSpecific" value="doc('../Dictionnaires/TacPointFrSpecificCode.gc')" />
  </iso:pattern>
  <iso:diagnostics>
    <iso:diagnostic xml:lang="en" id="D26458-en">NC1_DEPLOYREP.1: The current location of the units shall be provided. </iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26459-en">NC1_DEPLOYREP.1: The expected location of the units at end of deployment shall be provided.</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26460-en">NC1_DEPLOYREP.2: The symbol code of a deployment start point shall be of the following type:  G*C*OGI---*****.</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26461-en">NC1_DEPLOYREP.3: The symbol code of a deployment release point shall be of the following type: G*C*OGS---*****.</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26829-en">NC1_TacPoint.5: The responsible of the tactical point shall be a unit (NC1_Unit).</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26830-en">NC1_TacPoint.1: If the specialization Fr of the symbol code is filled in then the code of the filled in symbol must be the one corresponding to the value of the dictionary of specific symbol codes otherwise it must belong to one of the values ??of the dictionary of authorized symbol codes.</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26831-en">NC1_TacPoint.4: The type of the object has to have for value 40</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26832-en">NC1_TacPoint.2: The 13th and 14th characters of the Symbol Code must correspond to a value from the L105_2Code dictionary.</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26863-en">NC1_Unit.3: The 13th and 14th characters of the Symbol Code must correspond to a value from the L105_2Code dictionary.</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26864-en">NC1_Unit.9: When the unity(unit) is anticipated, the quality of the measure of location(localization) and the timestamp of the statement of its position on the ground must not be informed.</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26865-en">NC1_Unit.12: For a link of organic subordination, i.e. equal to 5 (RATORG), the period of detachment should not be informed else the period of detachment must be informed.</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26866-en">NC1_Unit.13: When the subordination type is provided, the superior unit shall be provided.</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26867-en">NC1_Unit.14: The unit's superior shall also be a unit (NC1_Unit).</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26868-en">NC1_Unit.15: The operational or logistic status of the unit shall be provided.</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26869-en">NC1_Unit.2: If the specialization Fr of the symbol code is filled in then the code of the filled in symbol must be the one corresponding to the value of the dictionary of specific symbol codes otherwise it must belong to one of the values ??of the dictionary of authorized symbol codes.</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26870-en">NC1_Unit.16: The location of the enemy unit shall be estimated only.</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26871-en">NC1_Unit.8: For a non-friendly unit, only URN and STNL16 IDs shall be provided else only EISN and TNL16 IDs shall be provided.</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26872-en">NC1_Unit.7: The type of the object has to have for value 0</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26873-en">NC1_Unit.19: The "commandAndControlRole" attribute must not have the values ??'Unknown' and 'No statement' for units from DQP.</iso:diagnostic>
  </iso:diagnostics>
</iso:schema>
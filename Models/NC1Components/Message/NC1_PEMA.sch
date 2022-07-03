<?xml version="1.0" encoding="utf-8"?>
<iso:schema queryBinding="xslt2" xmlns:iso="http://purl.oclc.org/dsdl/schematron">
  <!-- NC1 V.9.0.0 -->
  <iso:ns uri="http://www.w3.org/2001/XMLSchema-instance" prefix="xsi" />
  <iso:ns uri="urn:fra:nc1:message:pema" prefix="nc1pema" />
  <iso:pattern>
    <iso:title>NC1_PEMA validation rules</iso:title>
    <iso:rule context="/nc1pema:NC1_PEMA/intelCollectionMeansPlan/intelMeans/subordinateUnitId/@id">
      <iso:assert test="matches(.,'^0:')" diagnostics="D26687-en">NC1_PEMA.2: Chaque unité chargée de la recherche de renseignement doit être une unité (NC1_Unit).</iso:assert>
    </iso:rule>
    <iso:rule context="/nc1pema:NC1_PEMA/intelCollectionMeansPlan/intelMeans/associatedArea/freeShape">
      <iso:assert test="count(location) = 1" diagnostics="D26685-en">NC1_PEMA.3: La zone associée aux moyens de recherche doit être localisée.</iso:assert>
    </iso:rule>
    <iso:rule context="/nc1pema:NC1_PEMA/intelCollectionMeansPlan/intelMeans/associatedArea/physicalObject">
      <iso:assert test="count(location) = 1" diagnostics="D26682-en">NC1_PEMA.3: La zone associée aux moyens de recherche doit être localisée.</iso:assert>
    </iso:rule>
    <iso:rule context="/nc1pema:NC1_PEMA/intelCollectionMeansPlan/intelMeans/associatedArea/tacArea">
      <iso:assert test="count(location) = 1" diagnostics="D26686-en">NC1_PEMA.3: La zone associée aux moyens de recherche doit être localisée.</iso:assert>
    </iso:rule>
    <iso:rule context="/nc1pema:NC1_PEMA/intelCollectionMeansPlan/intelMeans/associatedArea/tacLine">
      <iso:assert test="count(location) = 1" diagnostics="D26684-en">NC1_PEMA.3: La zone associée aux moyens de recherche doit être localisée.</iso:assert>
    </iso:rule>
    <iso:rule context="/nc1pema:NC1_PEMA/intelCollectionMeansPlan/intelMeans/associatedArea/tacPoint">
      <iso:assert test="count(location) = 1" diagnostics="D26683-en">NC1_PEMA.3: La zone associée aux moyens de recherche doit être localisée.</iso:assert>
    </iso:rule>
    <iso:rule context="/nc1pema:NC1_PEMA/intelCollectionMeansPlan/intelRequirement/@id">
      <iso:assert test="matches(.,'^39:')" diagnostics="D26793-en">NC1_IntelRequirement.2: Le type de l'objet doit avoir pour valeur 39</iso:assert>
    </iso:rule>
    <iso:rule context="/nc1pema:NC1_PEMA/intelCollectionMeansPlan/intelRequirement/location/tacAreaId/@id">
      <iso:assert test="matches(.,'^42:')" diagnostics="D26792-en">NC1_IntelRequirement.3: Le besoin en renseignement doit être localisé au moyen d'un point tactique (NC1_TacPoint), d'une ligne tactique (NC1_TacLine), d'une surface tactique (NC1_TacArea), ou d'une forme graphique.</iso:assert>
    </iso:rule>
    <iso:rule context="/nc1pema:NC1_PEMA/intelCollectionMeansPlan/intelRequirement/location/tacLineId/@id">
      <iso:assert test="matches(.,'^41:')" diagnostics="D26790-en">NC1_IntelRequirement.3: Le besoin en renseignement doit être localisé au moyen d'un point tactique (NC1_TacPoint), d'une ligne tactique (NC1_TacLine), d'une surface tactique (NC1_TacArea), ou d'une forme graphique.</iso:assert>
    </iso:rule>
    <iso:rule context="/nc1pema:NC1_PEMA/intelCollectionMeansPlan/intelRequirement/location/tacPointId/@id">
      <iso:assert test="matches(.,'^40:')" diagnostics="D26791-en">NC1_IntelRequirement.3: Le besoin en renseignement doit être localisé au moyen d'un point tactique (NC1_TacPoint), d'une ligne tactique (NC1_TacLine), d'une surface tactique (NC1_TacArea), ou d'une forme graphique.</iso:assert>
    </iso:rule>
    <iso:rule context="//*[resolve-QName(@xsi:type,.)=QName('urn:fra:nc1:objet:obstacle','ObstacleType')]/tacticalData">
      <iso:assert test="if (frSpecificSymbol) then some $symbolCode in ($ObstacleFrSpecific//SimpleCodeList/Row/Value[@ColumnRef='code'][SimpleValue=current()/frSpecificSymbol]/../Value[@ColumnRef='codeSymbole']/SimpleValue) satisfies matches(symbolCode,$symbolCode) else some $symbolCode in ($ObstacleSymbol//SimpleCodeList/Row/Value[@ColumnRef='codeSymbole']/SimpleValue) satisfies matches(symbolCode,$symbolCode)" diagnostics="D26759-en">NC1_Obstacle.1: Si la spécialisation Fr du code symbole est renseignée alors le code du symbole renseigné doit être celui correspondant à la valeur du dictionnaire des codes symboles spécifiques sinon il doit appartenir à l'une des valeurs du dictionnaire des codes symboles autorisés.</iso:assert>
      <iso:assert test="if (frSpecificSymbol) then true() else some $symbolCode in ($ObstacleSymbol//SimpleCodeList/Row/Value[@ColumnRef='code'][SimpleValue&gt;0]/../Value[@ColumnRef='codeSymbole']/SimpleValue) satisfies matches(symbolCode,$symbolCode)">NC1_Obstacle.10: Dans le cas où la spécialisation Fr du code symbole n'est pas renseignée alors le code symbole doit exister et appartenir à l'une des valeurs positives du dictionnaire des codes symboles autorisés.</iso:assert>
    </iso:rule>
    <iso:rule context="//*[resolve-QName(@xsi:type,.)=QName('urn:fra:nc1:objet:obstacle','ObstacleType')]/tacticalData/symbolCode">
      <iso:assert test="some $Pays in ($L105_2//SimpleCodeList/Row/Value[@ColumnRef='short']/SimpleValue) satisfies substring(.,19,2) = substring($Pays,1,2)" diagnostics="D26754-en">NC1_Obstacle.2: Les 13ème et 14ème caractères du Code du symbole doivent correspondre à une valeur du dictionnaire L105_2Code.</iso:assert>
      <iso:assert test="if (matches(.,':...A')) then count(../../location/quality) + count(../../location/datetime) = 0 else true()" diagnostics="D26755-en">NC1_Obstacle.5: Lorsque l'obstacle est anticipé, la qualité de la mesure de localisation et l'horodatage du relevé de sa position sur le terrain ne doivent pas être renseignés.</iso:assert>
      <iso:assert test="if (matches(.,':.[SHJK]')) then (../../location/quality=1 or not(../../location/quality)) else true()" diagnostics="D26760-en">NC1_Obstacle.9: La localisation d'un obstacle ennemi ne peut qu'être estimée.</iso:assert>
      <iso:assert test="matches(.,':...[AP]')">NC1_Obstacle.11: Le 4ème caractère du Code symbole doit correspondre aux valeurs 'A' ou 'P'.</iso:assert>
    </iso:rule>
    <iso:rule context="//*[resolve-QName(@xsi:type,.)=QName('urn:fra:nc1:objet:obstacle','ObstacleType')]/@id">
      <iso:assert test="matches(.,'^17:')" diagnostics="D26761-en">NC1_Obstacle.4: Le type de l'objet doit avoir pour valeur 17</iso:assert>
    </iso:rule>
    <iso:rule context="//*[resolve-QName(@xsi:type,.)=QName('urn:fra:nc1:objet:obstacle','ObstacleType')]/tacticalData/number9">
      <iso:assert test="if (matches(../symbolCode, ':.F')) then matches(., '^FR[A-Z0-9]{4}[0-9]{3}') else true()" diagnostics="D26756-en">NC1_Obstacle.6: Dans le cas ou le symbole code représente un obstacle ami (2nde lettre du symbolCode = 'F') alors le numéro d'obstacle doit suivre le masque suivant : FR puis alphanumérique sur 4 caractères puis numérique sur 3 caractères.</iso:assert>
      <iso:assert test="if (matches(../symbolCode, ':.H')) then matches(., '^ENY [0-9]{5}') else true()">NC1_Obstacle.6: Dans le cas ou le symbole code représente un obstacle ennemi (2nde lettre du symbolCode = 'H') alors le numéro d'obstacle doit suivre le masque suivant : 'ENY ' puis numérique sur 5 caractères.</iso:assert>
      <iso:assert test="if (matches(../symbolCode, ':.[U]')) then matches(., '^UNK [0-9]{5}') else true()">NC1_Obstacle.6: Dans le cas ou le symbole code représente un obstacle inconnu ami (2nde lettre du symbolCode = 'U') alors le numéro d'obstacle doit suivre le masque suivant : 'UNK ' puis numérique sur 5 caractères.</iso:assert>
      <iso:assert test="if (matches(../symbolCode, ':.[FUH]')) then true() else false()">NC1_Obstacle.6: Le symbole code doit représenter soit un obstacle ami (2nde lettre du symbolCode = 'F') soit un obstacle ennemi (2nde lettre du symbolCode = 'H') soit un obstacle inconnu (2nde lettre du symbolCode = 'U').</iso:assert>
    </iso:rule>
    <iso:rule context="//*[resolve-QName(@xsi:type,.)=QName('urn:fra:nc1:objet:obstacle','ObstacleType')]/tacticalData/bypassRouteId/@id">
      <iso:assert test="matches(.,'^38:')" diagnostics="D26757-en">NC1_Obstacle.7: L'itinéraire de contournement de l'obstacle doit être un objet NC1_Route.</iso:assert>
    </iso:rule>
    <iso:rule context="//*[resolve-QName(@xsi:type,.)=QName('urn:fra:nc1:objet:obstacle','ObstacleType')]/tacticalData/responsibleUnitId/@id">
      <iso:assert test="matches(.,'^0:')" diagnostics="D26758-en">NC1_Obstacle.8: L'unité responsable de l'obstacle doit être une unité de l'Ordre de Bataille ami (NC1_Unit).</iso:assert>
    </iso:rule>
    <iso:rule context="//*[resolve-QName(@xsi:type,.)=QName('urn:fra:nc1:objet:facility','FacilityType')]/tacticalData">
      <iso:assert test="if (frSpecificSymbol) then some $symbolCode in ($FacilityFrSpecific//SimpleCodeList/Row/Value[@ColumnRef='code'][SimpleValue=current()/frSpecificSymbol]/../Value[@ColumnRef='codeSymbole']/SimpleValue) satisfies matches(symbolCode,$symbolCode) else some $symbolCode in ($FacilitySymbol//SimpleCodeList/Row/Value[@ColumnRef='codeSymbole']/SimpleValue) satisfies matches(symbolCode,$symbolCode)" diagnostics="D26358-en">NC1_Facility.1: Si la spécialisation Fr du code symbole est renseigné alors le code du symbole renseigné doit être celui correspondant à la valeur du dictionnaire des codes symboles spécifiques sinon il doit appartenir à l'une des valeur du dictionnaire des codes symboles autorisés.</iso:assert>
    </iso:rule>
    <iso:rule context="//*[resolve-QName(@xsi:type,.)=QName('urn:fra:nc1:objet:facility','FacilityType')]/tacticalData/symbolCode">
      <iso:assert test="some $Pays in ($L105_2//SimpleCodeList/Row/Value[@ColumnRef='short']/SimpleValue) satisfies substring(.,19,2) = substring($Pays,1,2)" diagnostics="D26364-en">NC1_Facility.2: Les 13ème et 14ème caractères du Code du symbole doivent correspondre à une valeur du dictionnaire L105_2Code.</iso:assert>
      <iso:assert test="if (matches(.,':...A')) then count(../../location/datetime) + count(../../location/quality) = 0 else true()" diagnostics="D26359-en">NC1_Facility.6: Lorsque l'installation est anticipée, l'horodatage du relevé de sa position sur le terrain et la qualité de la mesure de localisation ne doivent pas être renseignés.</iso:assert>
      <iso:assert test="if (matches(.,':.[SHJK]')) then (../../location/quality=1 or not(../../location/quality)) else true()" diagnostics="D26362-en">NC1_Facility.9: La localisation d'une installation ennemie ne peut qu'être estimée.</iso:assert>
      <iso:assert test="matches(.,':...[AP]')">NC1_Facility.10: Le 4ème caractère du Code symbole doit correspondre aux valeurs 'A' ou 'P'.</iso:assert>
    </iso:rule>
    <iso:rule context="//*[resolve-QName(@xsi:type,.)=QName('urn:fra:nc1:objet:facility','FacilityType')]/@id">
      <iso:assert test="matches(.,'^18:')" diagnostics="D26363-en">NC1_Facility.5: Le type de l'objet doit avoir pour valeur 18</iso:assert>
    </iso:rule>
    <iso:rule context="//*[resolve-QName(@xsi:type,.)=QName('urn:fra:nc1:objet:facility','FacilityType')]/tacticalData/responsibleUnitId/@id">
      <iso:assert test="matches(.,'^0:')" diagnostics="D26360-en">NC1_Facility.7: Le responsable de l'installation doit être une unité (NC1_Unit).</iso:assert>
    </iso:rule>
    <iso:rule context="//*[resolve-QName(@xsi:type,.)=QName('urn:fra:nc1:objet:facility','FacilityType')]/medicalFacilityData/admittedIndividualId/@id">
      <iso:assert test="matches(.,'^3:')" diagnostics="D26361-en">NC1_Facility.8: La personne admise dans une installation médicale doit être un individu (NC1_Individual).</iso:assert>
    </iso:rule>
    <iso:rule context="//*[resolve-QName(@xsi:type,.)=QName('urn:fra:nc1:objet:groundentity','GroundEntityType')]/@id">
      <iso:assert test="matches(.,'^20:')" diagnostics="D26789-en">NC1_GroundEntity.2: Le type de l'objet doit avoir pour valeur 20</iso:assert>
    </iso:rule>
    <iso:rule context="//*[resolve-QName(@xsi:type,.)=QName('urn:fra:nc1:objet:convoy','ConvoyType')]/tacticalData/symbolCode">
      <iso:assert test="matches(., '^APP6B:G.C.SLC')" diagnostics="D26848-en">NC1_Convoy.2: Le standard de symbologie utilisé doit être l'APP-6(B). Le code symbole d'un convoi doit être dans la famille G*C*SLC******** .</iso:assert>
      <iso:assert test="some $Pays in ($L105_2//SimpleCodeList/Row/Value[@ColumnRef='short']/SimpleValue) satisfies substring(.,19,2) = substring($Pays,1,2)" diagnostics="D26854-en">NC1_Convoy.3: Les 13ème et 14ème caractères du Code du symbole doivent correspondre à une valeur du dictionnaire L105_2Code.</iso:assert>
      <iso:assert test="if (matches(.,':...A')) then count(../../location/datetime) + count(../../location/quality) = 0 else true()" diagnostics="D26849-en">NC1_Convoy.7: Si le convoi est anticipé, l'horodatage du relevé de sa position sur le terrain et la qualité de la mesure de localisation ne doivent pas être renseignés.</iso:assert>
      <iso:assert test="if (matches(.,':.[SHJK]')) then (../../location/quality=1 or not(../../location/quality)) else true()" diagnostics="D26852-en">NC1_Convoy.10: La localisation d'un convoi ennemi ne peut qu'être estimée.</iso:assert>
      <iso:assert test="matches(.,':...[AP]')">NC1_Convoy.11: Le 4ème caractère du Code symbole doit correspondre aux valeurs 'A' ou 'P'.</iso:assert>
    </iso:rule>
    <iso:rule context="//*[resolve-QName(@xsi:type,.)=QName('urn:fra:nc1:objet:convoy','ConvoyType')]/@id">
      <iso:assert test="matches(.,'^16:')" diagnostics="D26853-en">NC1_Convoy.6: Le type de l'objet doit avoir pour valeur 16</iso:assert>
    </iso:rule>
    <iso:rule context="//*[resolve-QName(@xsi:type,.)=QName('urn:fra:nc1:objet:convoy','ConvoyType')]/tacticalData/belongingAgentId/@id">
      <iso:assert test="matches(.,'^[0-8]:')" diagnostics="D26850-en">NC1_Convoy.8: Les membres d'un convoi doivent être des agents (NC1_Unit, NC1_Organisation ou NC1_Individual).</iso:assert>
    </iso:rule>
    <iso:rule context="//*[resolve-QName(@xsi:type,.)=QName('urn:fra:nc1:objet:convoy','ConvoyType')]/movementData/routeId/@id">
      <iso:assert test="matches(.,'^38:')" diagnostics="D26851-en">NC1_Convoy.9: L'itinéraire associé au mouvement doit être un itinéraire (NC1_Route).</iso:assert>
    </iso:rule>
    <iso:rule context="//*[resolve-QName(@xsi:type,.)=QName('urn:fra:nc1:objet:seaparticipant','SeaParticipantType')]/tacticalData/symbolCode">
      <iso:assert test="matches(.,'^APP6B:S[AF]S')" diagnostics="D26932-en">NC1_SeaParticipant.2: Le standard de symbologie utilisé doit être l'APP-6(B). Le code symbole d'un participant maritime doit être dans les familles S*S*******--***. L'identité d'un participant doit être « ASSUMED FRIEND », ou « FRIEND » (A ou F dans l'APP6B).</iso:assert>
      <iso:assert test="some $Pays in ($L105_2//SimpleCodeList/Row/Value[@ColumnRef='short']/SimpleValue) satisfies substring(.,19,2) = substring($Pays,1,2)" diagnostics="D26937-en">NC1_SeaParticipant.3: Les 13ème et 14ème caractères du Code du symbole doivent correspondre à une valeur du dictionnaire L105_2Code.</iso:assert>
      <iso:assert test="matches(.,':...[AP]')">NC1_SeaParticipant.11: Le 4ème caractère du Code symbole doit correspondre aux valeurs 'A' ou 'P'.</iso:assert>
    </iso:rule>
    <iso:rule context="//*[resolve-QName(@xsi:type,.)=QName('urn:fra:nc1:objet:seaparticipant','SeaParticipantType')]/location">
      <iso:assert test="if (matches(../tacticalData/symbolCode,':...A')) then count(datetime) + count(quality) = 0 else true()" diagnostics="D26933-en">NC1_SeaParticipant.5: Lorsque le participant est anticipé, l'horodatage du relevé de sa position sur le terrain et la qualité de la mesure de localisation ne doivent pas être renseignés.</iso:assert>
    </iso:rule>
    <iso:rule context="//*[resolve-QName(@xsi:type,.)=QName('urn:fra:nc1:objet:seaparticipant','SeaParticipantType')]/@id">
      <iso:assert test="matches(.,'^10:')" diagnostics="D26936-en">NC1_SeaParticipant.6: Le type de l'objet doit avoir pour valeur 10</iso:assert>
    </iso:rule>
    <iso:rule context="//*[resolve-QName(@xsi:type,.)=QName('urn:fra:nc1:objet:seaparticipant','SeaParticipantType')]/tacticalData/referenceUnitId/@id">
      <iso:assert test="matches(.,'^0:')" diagnostics="D26934-en">NC1_SeaParticipant.7: L'unité représentante du participant doit être un objet NC1_Unit.</iso:assert>
    </iso:rule>
    <iso:rule context="//*[resolve-QName(@xsi:type,.)=QName('urn:fra:nc1:objet:seaparticipant','SeaParticipantType')]/status">
      <iso:assert test="operationalStatus or logisticStatus" diagnostics="D26935-en">NC1_SeaParticipant.8: L'état opérationnel ou l'état logistique du participant doit être renseigné.</iso:assert>
    </iso:rule>
    <iso:rule context="//*[resolve-QName(@xsi:type,.)=QName('urn:fra:nc1:objet:seaparticipant','SeaParticipantType')]/tacticalData/aggregatorParticipant">
      <iso:assert test="if (presence='true' or presence=1) then idParticipant else true()" diagnostics="D26938-en">NC1_SeaParticipant.10: L'identifiant du participant agrégateur doit être renseigné si l'indicateur de présence est à Vrai.</iso:assert>
    </iso:rule>
    <iso:rule context="//*[resolve-QName(@xsi:type,.)=QName('urn:fra:nc1:objet:seaparticipant','SeaParticipantType')]/tacticalData/aggregatorParticipant/idParticipant/@id">
      <iso:assert test="matches(.,'^10:')">NC1_SeaParticipant.10: L'identifiant du participant agrégateur doit représenter un participant maritime (la donnée id doit commencer par 10:).</iso:assert>
    </iso:rule>
    <iso:rule context="//*[resolve-QName(@xsi:type,.)=QName('urn:fra:nc1:objet:airparticipant','AirParticipantType')]/tacticalData/symbolCode">
      <iso:assert test="matches(.,'^APP6B:S[AF]A.......--...')" diagnostics="D26925-en">NC1_AirParticipant.2: Le standard de symbologie utilisé doit être l'APP-6(B). Le code symbole d'un participant aérien doit être dans les familles S*A*******--*** et l'identité d'un participant doit être « ASSUMED FRIEND », ou « FRIEND » (A ou F dans l'APP6B).</iso:assert>
      <iso:assert test="some $Pays in ($L105_2//SimpleCodeList/Row/Value[@ColumnRef='short']/SimpleValue) satisfies substring(.,19,2) = substring($Pays,1,2)" diagnostics="D26930-en">NC1_AirParticipant.5: Les 13ème et 14ème caractères du Code du symbole doivent correspondre à une valeur du dictionnaire L105_2Code.</iso:assert>
      <iso:assert test="matches(.,':...[AP]')">NC1_AirParticipant.11: Le 4ème caractère du Code symbole doit correspondre aux valeurs 'A' ou 'P'.</iso:assert>
    </iso:rule>
    <iso:rule context="//*[resolve-QName(@xsi:type,.)=QName('urn:fra:nc1:objet:airparticipant','AirParticipantType')]/location">
      <iso:assert test="if (matches(../tacticalData/symbolCode,':...A')) then count(datetime) + count(quality) = 0 else true()" diagnostics="D26926-en">NC1_AirParticipant.4: Lorsque le participant est anticipé, l'horodatage du relevé de sa position sur le terrain et la qualité de la mesure de localisation ne doivent pas être renseignés.</iso:assert>
    </iso:rule>
    <iso:rule context="//*[resolve-QName(@xsi:type,.)=QName('urn:fra:nc1:objet:airparticipant','AirParticipantType')]/@id">
      <iso:assert test="matches(.,'^11:')" diagnostics="D26929-en">NC1_AirParticipant.6: Le type de l'objet doit avoir pour valeur 11</iso:assert>
    </iso:rule>
    <iso:rule context="//*[resolve-QName(@xsi:type,.)=QName('urn:fra:nc1:objet:airparticipant','AirParticipantType')]/tacticalData/referenceUnitId/@id">
      <iso:assert test="matches(.,'^0:')" diagnostics="D26927-en">NC1_AirParticipant.7: L'unité représentante du participant doit être un objet NC1_Unit.</iso:assert>
    </iso:rule>
    <iso:rule context="//*[resolve-QName(@xsi:type,.)=QName('urn:fra:nc1:objet:airparticipant','AirParticipantType')]/status">
      <iso:assert test="operationalStatus or logisticStatus" diagnostics="D26928-en">NC1_AirParticipant.8: L'état opérationnel ou l'état logistique du participant doit être renseigné.</iso:assert>
    </iso:rule>
    <iso:rule context="//*[resolve-QName(@xsi:type,.)=QName('urn:fra:nc1:objet:airparticipant','AirParticipantType')]/tacticalData/aggregatorParticipant">
      <iso:assert test="if (presence=true()) then idParticipant else true()" diagnostics="D26931-en">NC1_AirParticipant.10: L'identifiant du participant agrégateur doit être renseigné si l'indicateur de présence est à Vrai.</iso:assert>
    </iso:rule>
    <iso:rule context="//*[resolve-QName(@xsi:type,.)=QName('urn:fra:nc1:objet:airparticipant','AirParticipantType')]/tacticalData/aggregatorParticipant/idParticipant/@id">
      <iso:assert test="matches(.,'^11:')">NC1_AirParticipant.10: L'identifiant du participant agrégateur doit représenter un participant aérien (la donnée id doit commencer par 11:).</iso:assert>
    </iso:rule>
    <iso:rule context="//*[resolve-QName(@xsi:type,.)=QName('urn:fra:nc1:objet:groundparticipant','GroundParticipantType')]/tacticalData/symbolCode">
      <iso:assert test="matches(.,'^APP6B:S[AF]G.E')" diagnostics="D26745-en">NC1_GroundParticipant.2: Le standard de symbologie utilisé doit être l'APP-6(B). Le code symbole d'un participant terrestre doit être dans les familles S*G*E*****--***. L'identité d'un participant doit être « ASSUMED FRIEND », ou « FRIEND » (A ou F dans l'APP6B).</iso:assert>
      <iso:assert test="some $Pays in ($L105_2//SimpleCodeList/Row/Value[@ColumnRef='short']/SimpleValue) satisfies substring(.,19,2) = substring($Pays,1,2)" diagnostics="D26750-en">NC1_GroundParticipant.3: Les 13ème et 14ème caractères du Code du symbole doivent correspondre à une valeur du dictionnaire L105_2Code.</iso:assert>
      <iso:assert test="matches(.,':...[AP]')">NC1_GroundParticipant.11: Le 4ème caractère du Code symbole doit correspondre aux valeurs 'A' ou 'P'.</iso:assert>
    </iso:rule>
    <iso:rule context="//*[resolve-QName(@xsi:type,.)=QName('urn:fra:nc1:objet:groundparticipant','GroundParticipantType')]/location">
      <iso:assert test="if (matches(../tacticalData/symbolCode,':...A')) then count(datetime)+count(quality) = 0 else true()" diagnostics="D26746-en">NC1_GroundParticipant.5: Lorsque le participant est anticipé, l'horodatage du relevé de sa position sur le terrain et la qualité de la mesure de localisation ne doivent pas être renseignés.</iso:assert>
    </iso:rule>
    <iso:rule context="//*[resolve-QName(@xsi:type,.)=QName('urn:fra:nc1:objet:groundparticipant','GroundParticipantType')]/@id">
      <iso:assert test="matches(.,'^9:')" diagnostics="D26749-en">NC1_GroundParticipant.6: Le type de l'objet doit avoir pour valeur 9</iso:assert>
    </iso:rule>
    <iso:rule context="//*[resolve-QName(@xsi:type,.)=QName('urn:fra:nc1:objet:groundparticipant','GroundParticipantType')]/tacticalData/referenceUnitId/@id">
      <iso:assert test="matches(.,'^0:')" diagnostics="D26747-en">NC1_GroundParticipant.7: L'unité représentante du participant doit être un objet NC1_Unit.</iso:assert>
    </iso:rule>
    <iso:rule context="//*[resolve-QName(@xsi:type,.)=QName('urn:fra:nc1:objet:groundparticipant','GroundParticipantType')]/status">
      <iso:assert test="operationalStatus or logisticStatus" diagnostics="D26748-en">NC1_GroundParticipant.8: L'état opérationnel ou l'état logistique du participant doit être renseigné.</iso:assert>
    </iso:rule>
    <iso:rule context="//*[resolve-QName(@xsi:type,.)=QName('urn:fra:nc1:objet:groundparticipant','GroundParticipantType')]/tacticalData/aggregatorParticipant">
      <iso:assert test="if (presence='true' or presence=1) then idParticipant else true()" diagnostics="D26751-en">NC1_GroundParticipant.10: L'identifiant du participant agrégateur doit être renseigné si l'indicateur de présence est à Vrai.</iso:assert>
    </iso:rule>
    <iso:rule context="//*[resolve-QName(@xsi:type,.)=QName('urn:fra:nc1:objet:groundparticipant','GroundParticipantType')]/tacticalData/aggregatorParticipant/idParticipant/@id">
      <iso:assert test="matches(.,'^9:')">NC1_GroundParticipant.10: L'identifiant du participant agrégateur doit représenter un participant terrestre (la donnée id doit commencer par 9:).</iso:assert>
    </iso:rule>
    <iso:rule context="//*[resolve-QName(@xsi:type,.)=QName('urn:fra:nc1:objet:groundtrack','GroundTrackType')]/tacticalData/symbolCode">
      <iso:assert test="matches(.,'^APP6B:S.(G.E|F.G[^B])')" diagnostics="D26911-en">NC1_GroundTrack.3: Le standard de symbologie utilisé doit être l'APP-6(B). Les familles autorisées par la règle sont : S*G*E*****--*** ou S*F*G*****--*** sauf S*F*GB****--***.</iso:assert>
      <iso:assert test="some $Pays in ($L105_2//SimpleCodeList/Row/Value[@ColumnRef='short']/SimpleValue) satisfies substring(.,19,2) = substring($Pays,1,2)" diagnostics="D26917-en">NC1_GroundTrack.4: Les 13ème et 14ème caractères du Code du symbole doivent correspondre à une valeur du dictionnaire L105_2Code.</iso:assert>
      <iso:assert test="if (matches(.,':...A')) then count(../../location/datetime) + count(../../location/quality) = 0 else true()" diagnostics="D26912-en">NC1_GroundTrack.6: Lorsque la piste est anticipée, l'horodatage du relevé de sa position et la qualité de la mesure de localisation sur le terrain ne doivent pas être renseignés.</iso:assert>
      <iso:assert test="if (matches(.,':.[SHJK]')) then (../../location/quality=1 or not(../../location/quality)) else true()" diagnostics="D26914-en">NC1_GroundTrack.9: La localisation d'une piste ennemie ne peut qu'être estimée.</iso:assert>
      <iso:assert test="matches(.,':...[AP]')">NC1_GroundTrack.11: Le 4ème caractère du Code symbole doit correspondre aux valeurs 'A' ou 'P'.</iso:assert>
    </iso:rule>
    <iso:rule context="//*[resolve-QName(@xsi:type,.)=QName('urn:fra:nc1:objet:groundtrack','GroundTrackType')]/@id">
      <iso:assert test="matches(.,'^12:')" diagnostics="D26916-en">NC1_GroundTrack.5: Le type de l'objet doit avoir pour valeur 12</iso:assert>
    </iso:rule>
    <iso:rule context="//*[resolve-QName(@xsi:type,.)=QName('urn:fra:nc1:objet:groundtrack','GroundTrackType')]/tacticalData/responsibleUnitId/@id">
      <iso:assert test="matches(.,'^0:')" diagnostics="D26915-en">NC1_GroundTrack.7: Le responsable du traitement de la piste doit être une unité (NC1_Unit).</iso:assert>
    </iso:rule>
    <iso:rule context="//*[resolve-QName(@xsi:type,.)=QName('urn:fra:nc1:objet:groundtrack','GroundTrackType')]/tacticalData/referenceUnitId/@id">
      <iso:assert test="matches(.,'^0:')" diagnostics="D26913-en">NC1_GroundTrack.8: L'unité d'appartenance de la piste  doit être une unité (NC1_Unit).</iso:assert>
    </iso:rule>
    <iso:rule context="//*[resolve-QName(@xsi:type,.)=QName('urn:fra:nc1:objet:airtrack','AirTrackType')]/tacticalData/symbolCode">
      <iso:assert test="matches(.,'^APP6B:S.A')" diagnostics="D26918-en">NC1_AirTrack.3: Le standard de symbologie utilisé doit être l'APP-6(B). Le code symbole d'une piste aérienne doit être dans la famille S*A************.</iso:assert>
      <iso:assert test="some $Pays in ($L105_2//SimpleCodeList/Row/Value[@ColumnRef='short']/SimpleValue) satisfies substring(.,19,2) = substring($Pays,1,2)" diagnostics="D26924-en">NC1_AirTrack.4: Les 13ème et 14ème caractères du Code du symbole doivent correspondre à une valeur du dictionnaire L105_2Code.</iso:assert>
      <iso:assert test="if (matches(.,':...A')) then count(../../location/quality) + count(../../location/datetime) = 0 else true()" diagnostics="D26919-en">NC1_AirTrack.6: Lorsque la piste est anticipée, la qualité de la mesure de localisation et l'horodatage du relevé de sa position sur le terrain ne doivent pas être renseignés.</iso:assert>
      <iso:assert test="if (matches(.,':.[SHJK]')) then (../../location/quality=1 or not(../../location/quality)) else true()" diagnostics="D26921-en">NC1_AirTrack.9: La localisation d'une piste ennemie ne peut qu'être estimée.</iso:assert>
      <iso:assert test="matches(.,':...[AP]')">NC1_AirTrack.11: Le 4ème caractère du Code symbole doit correspondre aux valeurs 'A' ou 'P'.</iso:assert>
    </iso:rule>
    <iso:rule context="//*[resolve-QName(@xsi:type,.)=QName('urn:fra:nc1:objet:airtrack','AirTrackType')]/@id">
      <iso:assert test="matches(.,'^15:')" diagnostics="D26923-en">NC1_AirTrack.5: Le type de l'objet doit avoir pour valeur 15</iso:assert>
    </iso:rule>
    <iso:rule context="//*[resolve-QName(@xsi:type,.)=QName('urn:fra:nc1:objet:airtrack','AirTrackType')]/tacticalData/responsibleUnitId/@id">
      <iso:assert test="matches(.,'^0:')" diagnostics="D26922-en">NC1_AirTrack.7: Le responsable du traitement de la piste doit être une unité (NC1_Unit).</iso:assert>
    </iso:rule>
    <iso:rule context="//*[resolve-QName(@xsi:type,.)=QName('urn:fra:nc1:objet:airtrack','AirTrackType')]/tacticalData/referenceUnitId/@id">
      <iso:assert test="matches(.,'^0:')" diagnostics="D26920-en">NC1_AirTrack.8: L'unité d'appartenance de la piste doit être un objet NC1_Unit.</iso:assert>
    </iso:rule>
    <iso:rule context="//*[resolve-QName(@xsi:type,.)=QName('urn:fra:nc1:objet:seatrack','SeaTrackType')]/tacticalData/symbolCode">
      <iso:assert test="matches(.,'^APP6B:S.S')" diagnostics="D26904-en">NC1_SeaTrack.2: Le standard de symbologie utilisé doit être l'APP-6(B). Le code symbole d'une piste maritime doit être dans la famille S*S************.</iso:assert>
      <iso:assert test="some $Pays in ($L105_2//SimpleCodeList/Row/Value[@ColumnRef='short']/SimpleValue) satisfies substring(.,19,2) = substring($Pays,1,2)" diagnostics="D26910-en">NC1_SeaTrack.3: Les 13ème et 14ème caractères du Code du symbole doivent correspondre à une valeur du dictionnaire L105_2Code.</iso:assert>
      <iso:assert test="if (matches(.,':...A')) then count(../../location/datetime) + count(../../location/quality) = 0 else true()" diagnostics="D26905-en">NC1_SeaTrack.6: Lorsque la piste est anticipée, l'horodatage du relevé de sa position sur le terrain et la qualité de la mesure de localisation ne doivent pas être renseignés.</iso:assert>
      <iso:assert test="if (matches(.,':.[SHJK]')) then(../../location/quality=1 or not(../../location/quality)) else true()" diagnostics="D26907-en">NC1_SeaTrack.9: La localisation d'une piste ennemie ne peut qu'être estimée.</iso:assert>
      <iso:assert test="matches(.,':...[AP]')">NC1_SeaTrack.11: Le 4ème caractère du Code symbole doit correspondre aux valeurs 'A' ou 'P'.</iso:assert>
    </iso:rule>
    <iso:rule context="//*[resolve-QName(@xsi:type,.)=QName('urn:fra:nc1:objet:seatrack','SeaTrackType')]/@id">
      <iso:assert test="matches(.,'^13:')" diagnostics="D26909-en">NC1_SeaTrack.5: Le type de l'objet doit avoir pour valeur 13</iso:assert>
    </iso:rule>
    <iso:rule context="//*[resolve-QName(@xsi:type,.)=QName('urn:fra:nc1:objet:seatrack','SeaTrackType')]/tacticalData/responsibleUnitId/@id">
      <iso:assert test="matches(.,'^0:')" diagnostics="D26908-en">NC1_SeaTrack.7: Le responsable du traitement de la piste doit être une unité (NC1_Unit).</iso:assert>
    </iso:rule>
    <iso:rule context="//*[resolve-QName(@xsi:type,.)=QName('urn:fra:nc1:objet:seatrack','SeaTrackType')]/tacticalData/referenceUnitId/@id">
      <iso:assert test="matches(.,'^0:')" diagnostics="D26906-en">NC1_SeaTrack.8: L'unité d'appartenance de la piste doit être un objet NC1_Unit.</iso:assert>
    </iso:rule>
    <iso:rule context="//*[resolve-QName(@xsi:type,.)=QName('urn:fra:nc1:objet:individual','IndividualType')]/tacticalData/symbolCode">
      <iso:assert test="matches(.,'^APP6B:G.C.MG(AUA|PI)')" diagnostics="D26774-en">NC1_Individual.2: Le standard de symbologie utilisé doit être l'APP-6(B). Le code symbole d'un individu doit être dans les familles G*C*MGAUA****** ou G*C*MGPI--***** .</iso:assert>
      <iso:assert test="some $Pays in ($L105_2//SimpleCodeList/Row/Value[@ColumnRef='short']/SimpleValue) satisfies substring(.,19,2) = substring($Pays,1,2)" diagnostics="D26782-en">NC1_Individual.3: Les 13ème et 14ème caractères du Code du symbole doivent correspondre à une valeur du dictionnaire L105_2Code.</iso:assert>
      <iso:assert test="if (matches(.,':...A')) then count(../../location/datetime) + count(../../location/quality) = 0 else true()" diagnostics="D26775-en">NC1_Individual.6: Lorsque l'individu est anticipé, l'horodatage du relevé de sa position sur le terrain et la qualité de la mesure de localisation ne doivent pas être renseignés.</iso:assert>
      <iso:assert test="if (matches(.,':.[SHJK]')) then (../../location/quality=1 or not(../../location/quality)) else true()" diagnostics="D26780-en">NC1_Individual.11: La localisation d'un individu ennemi ne peut qu'être estimée.</iso:assert>
      <iso:assert test="matches(.,':...[AP]')">NC1_Individual.12: Le 4ème caractère du Code symbole doit correspondre aux valeurs 'A' ou 'P'.</iso:assert>
    </iso:rule>
    <iso:rule context="//*[resolve-QName(@xsi:type,.)=QName('urn:fra:nc1:objet:individual','IndividualType')]/@id">
      <iso:assert test="matches(.,'^3:')" diagnostics="D26781-en">NC1_Individual.5: Le type de l'objet doit avoir pour valeur 3</iso:assert>
    </iso:rule>
    <iso:rule context="//*[resolve-QName(@xsi:type,.)=QName('urn:fra:nc1:objet:individual','IndividualType')]/tacticalData">
      <iso:assert test="if (matches(symbolCode,':.[AF]')) then count(specialIndicator) = 0 else true()" diagnostics="D26776-en">NC1_Individual.7: Lorsque l'individu est ami (FRIEND ou ASSUMED FRIEND), l'indicateur d'intérêt spécifique ne doit pas être renseigné.</iso:assert>
    </iso:rule>
    <iso:rule context="//*[resolve-QName(@xsi:type,.)=QName('urn:fra:nc1:objet:individual','IndividualType')]/tacticalData/responsibleUnitId/@id">
      <iso:assert test="matches(.,'^0:')" diagnostics="D26777-en">NC1_Individual.8: Le responsable de l'individu ou du groupe d'individus doit être une unité (NC1_Unit).</iso:assert>
    </iso:rule>
    <iso:rule context="//*[resolve-QName(@xsi:type,.)=QName('urn:fra:nc1:objet:individual','IndividualType')]/historyItems/historyItem/eventId/@id">
      <iso:assert test="matches(.,'^30:')" diagnostics="D26778-en">NC1_Individual.9: L'objet NC1 relié au fait de main courante doit être un événement (NC1_Event).</iso:assert>
    </iso:rule>
    <iso:rule context="//*[resolve-QName(@xsi:type,.)=QName('urn:fra:nc1:objet:individual','IndividualType')]/administrativeProperties/unitId/@id">
      <iso:assert test="matches(.,'^0:')" diagnostics="D26779-en">NC1_Individual.10: L'unité d'appartenance de l'individu doit être une unité (NC1_Unit).</iso:assert>
    </iso:rule>
    <iso:rule context="//*[resolve-QName(@xsi:type,.)=QName('urn:fra:nc1:objet:unit','UnitType')]/tacticalData">
      <iso:assert test="if (frSpecificSymbol) then some $symbolCode in ($UnitFrSpecific//SimpleCodeList/Row/Value[@ColumnRef='code'][SimpleValue=current()/frSpecificSymbol]/../Value[@ColumnRef='codeSymbole']/SimpleValue) satisfies matches(symbolCode,$symbolCode) else some $symbolCode in ($UnitSymbol//SimpleCodeList/Row/Value[@ColumnRef='codeSymbole']/SimpleValue) satisfies matches(symbolCode,$symbolCode)" diagnostics="D26869-en">NC1_Unit.2: Si la spécialisation Fr du code symbole est renseignée alors le code du symbole renseigné doit être celui correspondant à la valeur du dictionnaire des codes symboles spécifiques sinon il doit appartenir à l'une des valeur du dictionnaire des codes symboles autorisés.</iso:assert>
      <iso:assert test="if (matches(symbolCode,':.[AF]')) then count(eisn) + count(tnl16) = 0 else count(urn) + count(stnl16) = 0" diagnostics="D26871-en">NC1_Unit.8: Pour une unité non amie, les identifiants URN et STNL16 ne doivent pas être renseignés et pour une unité amie, les identifiants EISN et TNL16 ne doivent pas être renseignés.</iso:assert>
      <iso:assert test="if (frSpecificSymbol) then true() else some $symbolCode in ($UnitSymbol//SimpleCodeList/Row/Value[@ColumnRef='code'][SimpleValue&gt;0]/../Value[@ColumnRef='codeSymbole']/SimpleValue) satisfies matches(symbolCode,$symbolCode)">NC1_Unit.23: Dans le cas où la spécialisation Fr du code symbole n'est pas renseignée alors le code symbole doit exister et appartenir à l'une des valeurs positives du dictionnaire des codes symboles autorisés.</iso:assert>
    </iso:rule>
    <iso:rule context="//*[resolve-QName(@xsi:type,.)=QName('urn:fra:nc1:objet:unit','UnitType')]/tacticalData/symbolCode">
      <iso:assert test="some $Pays in ($L105_2//SimpleCodeList/Row/Value[@ColumnRef='short']/SimpleValue) satisfies substring(.,19,2) = substring($Pays,1,2)" diagnostics="D26863-en">NC1_Unit.3: Les 13ème et 14ème caractères du Code du symbole doivent correspondre à une valeur du dictionnaire L105_2Code.</iso:assert>
      <iso:assert test="if (matches(.,':...A')) then count(../../location/datetime) + count(../../location/quality) = 0 else true()" diagnostics="D26864-en">NC1_Unit.9: Lorsque l'unité est anticipée, la qualité de la mesure de localisation et l'horodatage du relevé de sa position sur le terrain ne doivent pas être renseignés.</iso:assert>
      <iso:assert test="if (matches(.,':.[SHJK]')) then (matches(../../location/quality,'1') or not(../../location/quality)) else true()" diagnostics="D26870-en">NC1_Unit.16: La localisation d'une unité ennemie ne peut qu'être estimée.</iso:assert>
      <iso:assert test="matches(.,':...[AP]')">NC1_Unit.24: Le 4ème caractère du Code symbole doit correspondre aux valeurs 'A' ou 'P'.</iso:assert>
    </iso:rule>
    <iso:rule context="//*[resolve-QName(@xsi:type,.)=QName('urn:fra:nc1:objet:unit','UnitType')]/@id">
      <iso:assert test="matches(.,'^0:')" diagnostics="D26872-en">NC1_Unit.7: Le type de l'objet doit avoir pour valeur 0</iso:assert>
    </iso:rule>
    <iso:rule context="//*[resolve-QName(@xsi:type,.)=QName('urn:fra:nc1:objet:unit','UnitType')]/tacticalData/subordination/subordinationType">
      <iso:assert test="if (.=5) then not(../detachmentPeriod) else ../detachmentPeriod" diagnostics="D26865-en">NC1_Unit.12: Pour un lien de subordination organique, i.e. égal à 5 (RATORG), la période de détachement ne doit pas être renseignée sinon cette période de détachement doit être renseignée.</iso:assert>
      <iso:assert test="../superiorUnitId" diagnostics="D26866-en">NC1_Unit.13: Lorsque le type de subordination est renseigné, le supérieur doit également être renseigné.</iso:assert>
    </iso:rule>
    <iso:rule context="//*[resolve-QName(@xsi:type,.)=QName('urn:fra:nc1:objet:unit','UnitType')]/tacticalData/subordination/superiorUnitId/@id">
      <iso:assert test="matches(.,'^0:')" diagnostics="D26867-en">NC1_Unit.14: Le supérieur de l'unité doit également être une unité (NC1_Unit).</iso:assert>
    </iso:rule>
    <iso:rule context="//*[resolve-QName(@xsi:type,.)=QName('urn:fra:nc1:objet:unit','UnitType')]/status">
      <iso:assert test="logisticStatus or operationalStatus" diagnostics="D26868-en">NC1_Unit.15: L'état opérationnel ou l'état logistique de l'unité doit être renseigné.</iso:assert>
    </iso:rule>
    <iso:rule context="//*[resolve-QName(@xsi:type,.)=QName('urn:fra:nc1:objet:unit','UnitType')]/status/operationalStatus">
      <iso:assert test="effectif or personnelTiredness or equipment or fuel or ammunitions">NC1_Unit.15: L'effectif ou l'état de fatigue ou l'état matériel ou l'état carburant ou l'état munitions doit être renseigné.</iso:assert>
    </iso:rule>
    <iso:rule context="//*[resolve-QName(@xsi:type,.)=QName('urn:fra:nc1:objet:unit','UnitType')]/tacticalData/commandAndControlRole">
      <iso:assert test="if (matches(../../@id,':0:')) then . &gt; 1 else true()" diagnostics="D26873-en">NC1_Unit.19: L'attribut "commandAndControlRole" ne doit pas avoir les valeurs 'Inconnu' et 'No statement' pour les unités issues des DQP.</iso:assert>
    </iso:rule>
    <iso:rule context="//*[resolve-QName(@xsi:type,.)=QName('urn:fra:nc1:objet:organisation','OrganisationType')]/tacticalData/symbolCode">
      <iso:assert test="matches(.,'^APP6B:S.G.(USA|--------..-)')" diagnostics="D26783-en">NC1_Organisation.2: Le standard de symbologie utilisé doit être l'APP-6(B). Le code symbole d'une organisation doit être dans les familles S*G*USA******** ou S*G*--------**- .</iso:assert>
      <iso:assert test="some $Pays in ($L105_2//SimpleCodeList/Row/Value[@ColumnRef='short']/SimpleValue) satisfies substring(.,19,2) = substring($Pays,1,2)" diagnostics="D26788-en">NC1_Organisation.3: Les 13ème et 14ème caractères du Code du symbole doivent correspondre à une valeur du dictionnaire L105_2Code.</iso:assert>
      <iso:assert test="if (matches(.,':...A')) then count(../../location/datetime)+count(../../location/quality) = 0 else true()" diagnostics="D26784-en">NC1_Organisation.6: Lorsque l'organisation est anticipée, l'horodatage du relevé de sa position sur le terrain et la qualité de la mesure de localisation ne doivent pas être renseignés.</iso:assert>
      <iso:assert test="if (matches(.,':.[SHJK]')) then (../../location/quality=1 or not(../../location/quality)) else true()" diagnostics="D26786-en">NC1_Organisation.8: La localisation d'une organisation ennemie ne peut qu'être estimée.</iso:assert>
      <iso:assert test="matches(.,':...[AP]')">NC1_Organisation.9: Le 4ème caractère du Code symbole doit correspondre aux valeurs 'A' ou 'P'.</iso:assert>
    </iso:rule>
    <iso:rule context="//*[resolve-QName(@xsi:type,.)=QName('urn:fra:nc1:objet:organisation','OrganisationType')]/@id">
      <iso:assert test="matches(.,'^2:')" diagnostics="D26787-en">NC1_Organisation.5: Le type de l'objet doit avoir pour valeur 2</iso:assert>
    </iso:rule>
    <iso:rule context="//*[resolve-QName(@xsi:type,.)=QName('urn:fra:nc1:objet:organisation','OrganisationType')]/tacticalData/responsibleUnitId/@id">
      <iso:assert test="matches(.,'^0:')" diagnostics="D26785-en">NC1_Organisation.7: Le responsable de l'organisation doit être une unité (NC1_Unit).</iso:assert>
    </iso:rule>
    <iso:rule context="/nc1pema:NC1_PEMA/intelCollectionMeansPlan/involvedRoute/location/endPoint/symbolCode">
      <iso:assert test="matches(.,'^APP6B:G.C.OG')" diagnostics="D26856-en">NC1_Route.2: Le standard de symbologie utilisé doit être l'APP-6(B). Le code symbole d'un point sur un itinéraire doit être dans la famille G*C*OG********* .</iso:assert>
      <iso:assert test="some $Pays in ($L105_2//SimpleCodeList/Row/Value[@ColumnRef='short']/SimpleValue) satisfies substring(.,19,2) = substring($Pays,1,2)" diagnostics="D26862-en">NC1_Route.4: Les 13ème et 14ème caractères du Code du symbole du point d'arrivée doivent correspondre à une valeur du dictionnaire L105_2Code.</iso:assert>
      <iso:assert test="matches(.,':...[AP]')">NC1_Route.8: Le 4ème caractère du Code symbole du point d'arrivée doit correspondre aux valeurs 'A' ou 'P'.</iso:assert>
    </iso:rule>
    <iso:rule context="/nc1pema:NC1_PEMA/intelCollectionMeansPlan/involvedRoute/location/startPoint/symbolCode">
      <iso:assert test="matches(.,'^APP6B:G.C.OG')" diagnostics="D26855-en">NC1_Route.2: Le standard de symbologie utilisé doit être l'APP-6(B). Le code symbole d'un point sur un itinéraire doit être dans la famille G*C*OG********* .</iso:assert>
      <iso:assert test="some $Pays in ($L105_2//SimpleCodeList/Row/Value[@ColumnRef='short']/SimpleValue) satisfies substring(.,19,2) = substring($Pays,1,2)" diagnostics="D26861-en">NC1_Route.4: Les 13ème et 14ème caractères du Code du symbole du point de départ doivent correspondre à une valeur du dictionnaire L105_2Code.</iso:assert>
      <iso:assert test="matches(.,':...[AP]')">NC1_Route.8: Le 4ème caractère du Code symbole du point de départ doit correspondre aux valeurs 'A' ou 'P'.</iso:assert>
    </iso:rule>
    <iso:rule context="/nc1pema:NC1_PEMA/intelCollectionMeansPlan/involvedRoute/@id">
      <iso:assert test="matches(.,'^38:')" diagnostics="D26860-en">NC1_Route.5: Le type de l'objet doit avoir pour valeur 38</iso:assert>
    </iso:rule>
    <iso:rule context="/nc1pema:NC1_PEMA/intelCollectionMeansPlan/involvedRoute/location/endTacPointId/@id">
      <iso:assert test="matches(.,'^40:')" diagnostics="D26858-en">NC1_Route.6: L'identifiant du point d'arrivée de l'itinéraire doit être celui d'un point tactique (NC1_TacPoint).</iso:assert>
    </iso:rule>
    <iso:rule context="/nc1pema:NC1_PEMA/intelCollectionMeansPlan/involvedRoute/location/startTacPointId/@id">
      <iso:assert test="matches(.,'^40:')" diagnostics="D26857-en">NC1_Route.6: L'identifiant du point de départ de l'itinéraire doit être celui d'un point tactique (NC1_TacPoint).</iso:assert>
    </iso:rule>
    <iso:rule context="/nc1pema:NC1_PEMA/intelCollectionMeansPlan/involvedRoute/location/segment/groundEntityId/@id">
      <iso:assert test="matches(.,'^20:')" diagnostics="D26859-en">NC1_Route.7: L'entité terrain représentant un tronçon d'itinéraire doit être une entité terrain (NC1_GroundEntity).</iso:assert>
    </iso:rule>
    <iso:rule context="/nc1pema:NC1_PEMA/intelCollectionMeansPlan/involvedTacPoint/tacticalData">
      <iso:assert test="if (frSpecificSymbol) then some $symbolCode in ($TacPointFrSpecific//SimpleCodeList/Row/Value[@ColumnRef='code'][SimpleValue=current()/frSpecificSymbol]/../Value[@ColumnRef='codeSymbole']/SimpleValue) satisfies matches(symbolCode,$symbolCode) else some $symbolCode in ($TacPointSymbol//SimpleCodeList/Row/Value[@ColumnRef='codeSymbole']/SimpleValue) satisfies matches(symbolCode,$symbolCode)" diagnostics="D26830-en">NC1_TacPoint.1: Si la spécialisation Fr du code symbole est renseignée alors le code du symbole renseigné doit être celui correspondant à la valeur du dictionnaire des codes symboles spécifiques sinon il doit appartenir à l'une des valeurs du dictionnaire des codes symboles autorisés.</iso:assert>
      <iso:assert test="if (frSpecificSymbol) then true() else some $symbolCode in ($TacPointSymbol//SimpleCodeList/Row/Value[@ColumnRef='code'][SimpleValue&gt;0]/../Value[@ColumnRef='codeSymbole']/SimpleValue) satisfies matches(symbolCode,$symbolCode)">NC1_TacPoint.6: Dans le cas où la spécialisation Fr du code symbole n'est pas renseignée alors le code symbole doit exister et appartenir à l'une des valeurs positives du dictionnaire des codes symboles autorisés.</iso:assert>
    </iso:rule>
    <iso:rule context="/nc1pema:NC1_PEMA/intelCollectionMeansPlan/involvedTacPoint/tacticalData/symbolCode">
      <iso:assert test="some $Pays in ($L105_2//SimpleCodeList/Row/Value[@ColumnRef='short']/SimpleValue) satisfies substring(.,19,2) = substring($Pays,1,2)" diagnostics="D26832-en">NC1_TacPoint.2: Les 13ème et 14ème caractères du Code du symbole doivent correspondre à une valeur du dictionnaire L105_2Code.</iso:assert>
      <iso:assert test="matches(.,':...[AP]')">NC1_TacPoint.7: Le 4ème caractère du Code symbole doit correspondre aux valeurs 'A' ou 'P'.</iso:assert>
    </iso:rule>
    <iso:rule context="/nc1pema:NC1_PEMA/intelCollectionMeansPlan/involvedTacPoint/@id">
      <iso:assert test="matches(.,'^40:')" diagnostics="D26831-en">NC1_TacPoint.4: Le type de l'objet doit avoir pour valeur 40</iso:assert>
    </iso:rule>
    <iso:rule context="/nc1pema:NC1_PEMA/intelCollectionMeansPlan/involvedTacPoint/tacticalData/responsibleUnitId/@id">
      <iso:assert test="matches(.,'^0:')" diagnostics="D26829-en">NC1_TacPoint.5: Le responsable du point tactique doit être une unité (NC1_Unit).</iso:assert>
    </iso:rule>
    <iso:rule context="/nc1pema:NC1_PEMA/intelCollectionMeansPlan/involvedTacLine/tacticalData">
      <iso:assert test="if (frSpecificSymbol) then some $symbolCode in ($TacLineFrSpecific//SimpleCodeList/Row/Value[@ColumnRef='code'][SimpleValue=current()/frSpecificSymbol]/../Value[@ColumnRef='codeSymbole']/SimpleValue) satisfies matches(symbolCode,$symbolCode) else some $symbolCode in ($TacLineSymbol//SimpleCodeList/Row/Value[@ColumnRef='codeSymbole']/SimpleValue) satisfies matches(symbolCode,$symbolCode)" diagnostics="D26892-en">NC1_TacLine.3: Si la spécialisation Fr du code symbole est renseignée alors le code du symbole renseigné doit être celui correspondant à la valeur du dictionnaire des codes symboles spécifiques sinon il doit appartenir à l'une des valeurs du dictionnaire des codes symboles autorisés.</iso:assert>
      <iso:assert test="if (frSpecificSymbol) then true() else some $symbolCode in ($TacLineSymbol//SimpleCodeList/Row/Value[@ColumnRef='code'][SimpleValue&gt;0]/../Value[@ColumnRef='codeSymbole']/SimpleValue) satisfies matches(symbolCode,$symbolCode)">NC1_TacLine.11: Dans le cas où la spécialisation Fr du code symbole n'est pas renseignée alors le code symbole doit exister et appartenir à l'une des valeurs positives du dictionnaire des codes symboles autorisés.</iso:assert>
    </iso:rule>
    <iso:rule context="/nc1pema:NC1_PEMA/intelCollectionMeansPlan/involvedTacLine/tacticalData/symbolCode">
      <iso:assert test="some $Pays in ($L105_2//SimpleCodeList/Row/Value[@ColumnRef='short']/SimpleValue) satisfies substring(.,19,2) = substring($Pays,1,2)" diagnostics="D26898-en">NC1_TacLine.4: Les 13ème et 14ème caractères du Code du symbole doivent correspondre à une valeur du dictionnaire L105_2Code.</iso:assert>
      <iso:assert test="if (matches(., ':G.C.MGLB')) then (../../specificData/leftUnitId or ../../specificData/rightUnitId) else true()" diagnostics="D26893-en">NC1_TacLine.7: Si la ligne tactique est une limite entre unités, l'unité à gauche ou l'unité à droite de la limite doit être renseignée sinon aucune ne doit être renseignée.</iso:assert>
      <iso:assert test="matches(.,':...[AP]')">NC1_TacLine.12: Le 4ème caractère du Code symbole doit correspondre aux valeurs 'A' ou 'P'.</iso:assert>
    </iso:rule>
    <iso:rule context="/nc1pema:NC1_PEMA/intelCollectionMeansPlan/involvedTacLine/@id">
      <iso:assert test="matches(.,'^41:')" diagnostics="D26897-en">NC1_TacLine.6: Le type de l'objet doit avoir pour valeur 41</iso:assert>
    </iso:rule>
    <iso:rule context="/nc1pema:NC1_PEMA/intelCollectionMeansPlan/involvedTacLine/specificData/leftUnitId/@id">
      <iso:assert test="matches(.,'^0:')" diagnostics="D26894-en">NC1_TacLine.8: L'unité à gauche de la limite doit être une unité (NC1_Unit).</iso:assert>
    </iso:rule>
    <iso:rule context="/nc1pema:NC1_PEMA/intelCollectionMeansPlan/involvedTacLine/specificData/rightUnitId/@id">
      <iso:assert test="matches(.,'^0:')" diagnostics="D26895-en">NC1_TacLine.8: L'unité à droite de la limite doit être une unité (NC1_Unit).</iso:assert>
    </iso:rule>
    <iso:rule context="/nc1pema:NC1_PEMA/intelCollectionMeansPlan/involvedTacLine/tacticalData/responsibleUnitId/@id">
      <iso:assert test="matches(.,'^0:')" diagnostics="D26896-en">NC1_TacLine.9: Le responsable de la ligne tactique doit être une unité (NC1_Unit).</iso:assert>
    </iso:rule>
    <iso:rule context="/nc1pema:NC1_PEMA/intelCollectionMeansPlan/involvedTacLine/location/multipoint">
      <iso:assert test="count(point) = 2" diagnostics="D26899-en">NC1_TacLine.10: Le nombre de points pour la localisation de type multipoint est de 2 points.</iso:assert>
    </iso:rule>
    <iso:rule context="/nc1pema:NC1_PEMA/intelCollectionMeansPlan/involvedTacArea/tacticalData">
      <iso:assert test="if (frSpecificSymbol) then some $symbolCode in ($TacAreaFrSpecific//SimpleCodeList/Row/Value[@ColumnRef='code'][SimpleValue=current()/frSpecificSymbol]/../Value[@ColumnRef='codeSymbole']/SimpleValue) satisfies matches(symbolCode,$symbolCode) else some $symbolCode in ($TacAreaSymbol//SimpleCodeList/Row/Value[@ColumnRef='codeSymbole']/SimpleValue) satisfies matches(symbolCode,$symbolCode)" diagnostics="D26902-en">NC1_TacArea.1: Si la spécialisation Fr du code symbole est renseignée alors le code du symbole renseigné doit être celui correspondant à la valeur du dictionnaire des codes symboles spécifiques sinon il doit appartenir à l'une des valeurs du dictionnaire des codes symboles autorisés.</iso:assert>
      <iso:assert test="if (frSpecificSymbol) then true() else some $symbolCode in ($TacAreaSymbol//SimpleCodeList/Row/Value[@ColumnRef='code'][SimpleValue&gt;0]/../Value[@ColumnRef='codeSymbole']/SimpleValue) satisfies matches(symbolCode,$symbolCode)">NC1_TacArea.6: Dans le cas ou la spécialisation Fr du code symbole n'est pas renseigné alors le code symbole doit exister et appartenir à l'une des valeurs positives du dictionnaire des codes symbole autorisés.</iso:assert>
    </iso:rule>
    <iso:rule context="/nc1pema:NC1_PEMA/intelCollectionMeansPlan/involvedTacArea/tacticalData/symbolCode">
      <iso:assert test="some $Pays in ($L105_2//SimpleCodeList/Row/Value[@ColumnRef='short']/SimpleValue) satisfies substring(.,19,2) = substring($Pays,1,2)" diagnostics="D26900-en">NC1_TacArea.2: Les 13ème et 14ème caractères du Code du symbole doivent correspondre à une valeur du dictionnaire L105_2Code.</iso:assert>
      <iso:assert test="matches(.,':...[AP]')">NC1_TacArea.7: Le 4ème caractère du Code symbole doit correspondre aux valeurs 'A' ou 'P'.</iso:assert>
    </iso:rule>
    <iso:rule context="/nc1pema:NC1_PEMA/intelCollectionMeansPlan/involvedTacArea/@id">
      <iso:assert test="matches(.,'^42:')" diagnostics="D26903-en">NC1_TacArea.4: Le type de l'objet doit avoir pour valeur 42.</iso:assert>
    </iso:rule>
    <iso:rule context="/nc1pema:NC1_PEMA/intelCollectionMeansPlan/involvedTacArea/tacticalData/responsibleUnitId/@id">
      <iso:assert test="matches(.,'^0:')" diagnostics="D26901-en">NC1_TacArea.5: Le responsable de la surface tactique doit être une unité (NC1_Unit).</iso:assert>
    </iso:rule>
    <iso:rule context="/nc1pema:NC1_PEMA/intelCollectionMeansPlan/involvedEvent/tacticalData/symbolCode">
      <iso:assert test="matches(.,'^APP6B:G.O')" diagnostics="D26821-en">NC1_Event.2: Le standard de symbologie utilisé doit être l'APP-6(B). Le code symbole d'un événement doit être dans la famille G*O************ .</iso:assert>
      <iso:assert test="some $Pays in ($L105_2//SimpleCodeList/Row/Value[@ColumnRef='short']/SimpleValue) satisfies substring(.,19,2) = substring($Pays,1,2)" diagnostics="D26828-en">NC1_Event.3: Les 13ème et 14ème caractères du Code du symbole doivent correspondre à une valeur du dictionnaire L105_2Code.</iso:assert>
      <iso:assert test="if (matches(.,':...A')) then count(../../location/quality) = 0 else true()" diagnostics="D26822-en">NC1_Event.6: Lorsque l'événement est anticipé, la qualité de la mesure de localisation ne doit pas être renseignée.</iso:assert>
      <iso:assert test="if (matches(.,':.[SHJK]')) then (../../location/quality=1 or not(../../location/quality)) else true()" diagnostics="D26826-en">NC1_Event.9: La localisation d'un événement ennemi ne peut qu'être estimée.</iso:assert>
      <iso:assert test="matches(.,':...[AP]')">NC1_Event.10: Le 4ème caractère du Code symbole doit correspondre aux valeurs 'A' ou 'P'.</iso:assert>
    </iso:rule>
    <iso:rule context="/nc1pema:NC1_PEMA/intelCollectionMeansPlan/involvedEvent/@id">
      <iso:assert test="matches(.,'^30:')" diagnostics="D26827-en">NC1_Event.5: Le type de l'objet doit avoir pour valeur 30</iso:assert>
    </iso:rule>
    <iso:rule context="/nc1pema:NC1_PEMA/intelCollectionMeansPlan/involvedEvent/tacticalData/responsibleUnitId/@id">
      <iso:assert test="matches(.,'^0:')" diagnostics="D26825-en">NC1_Event.7: Le responsable de la gestion de l'événement doit être une unité (NC1_Unit).</iso:assert>
    </iso:rule>
    <iso:rule context="/nc1pema:NC1_PEMA/intelCollectionMeansPlan/involvedEvent/tacticalData/initiatorEntityId/@id">
      <iso:assert test="matches(.,'^[0-9]:') or matches(.,'^1[01235]:')" diagnostics="D26823-en">NC1_Event.8: L'acteur ayant provoqué l'événement doit être un agent (NC1_Unit, NC1_Organisation ou NC1_Individual) ou une piste (NC1_GrountTrack, NC1_AirTrack ou NC1_SeaTrack) ou un participant (NC1_GrountParticipant, NC1_AirParticipant ou NC1_SeaParticipant).</iso:assert>
    </iso:rule>
    <iso:rule context="/nc1pema:NC1_PEMA/intelCollectionMeansPlan/involvedEvent/tacticalData/involvedEntityId/@id">
      <iso:assert test="matches(.,'^[0-9]:') or matches(.,'^1[01235]:')" diagnostics="D26824-en">NC1_Event.8: L'acteur impliqué dans l'événement doit être un agent (NC1_Unit, NC1_Organisation ou NC1_Individual) ou une piste (NC1_GrountTrack, NC1_AirTrack ou NC1_SeaTrack) ou un participant (NC1_GrountParticipant, NC1_AirParticipant ou NC1_SeaParticipant).</iso:assert>
    </iso:rule>
    <iso:rule context="/nc1pema:NC1_PEMA/intelCollectionMeansPlan/involvedCbrnEvent/tacticalData/symbolCode">
      <iso:assert test="matches(., '^APP6B:G.C.BW[^D]')" diagnostics="D26794-en">NC1_CbrnEvent.2: Le standard de symbologie utilisé doit être l'APP-6(B). Le code symbole d'un événement NRBC doit être dans la famille G*C*BW********* mais pas dans la famille G*C*BWD********</iso:assert>
      <iso:assert test="some $Pays in ($L105_2//SimpleCodeList/Row/Value[@ColumnRef='short']/SimpleValue) satisfies substring(.,19,2) = substring($Pays,1,2)" diagnostics="D26796-en">NC1_CbrnEvent.3: Les 13ème et 14ème caractères du Code du symbole doivent correspondre à une valeur du dictionnaire L105_2Code.</iso:assert>
      <iso:assert test="matches(.,':...[AP]')">NC1_CbrnEvent.6: Le 4ème caractère du Code symbole doit correspondre aux valeurs 'A' ou 'P'.</iso:assert>
    </iso:rule>
    <iso:rule context="/nc1pema:NC1_PEMA/intelCollectionMeansPlan/involvedCbrnEvent/@id">
      <iso:assert test="matches(.,'^31:')" diagnostics="D26795-en">NC1_CbrnEvent.5: Le type de l'objet doit avoir pour valeur 31</iso:assert>
    </iso:rule>
    <iso:rule context="/nc1pema:NC1_PEMA/intelCollectionMeansPlan/involvedFreeShape/tacticalData/style/line/type">
      <iso:assert test=". != 0">NC1_FreeShape.1: Le type de la forme libre de style ligne ne peut être égal à 0.</iso:assert>
    </iso:rule>
    <iso:rule context="/nc1pema:NC1_PEMA/intelCollectionMeansPlan/involvedFreeShape/@id">
      <iso:assert test="matches(.,'^44:')" diagnostics="D26752-en">NC1_FreeShape.4: Le type de l'objet doit avoir pour valeur 44</iso:assert>
    </iso:rule>
    <iso:rule context="/nc1pema:NC1_PEMA/intelCollectionMeansPlan/involvedFreeShape/location/point">
      <iso:assert test="not(../../tacticalData/style/line) and not(../../tacticalData/style/area)" diagnostics="D26753-en">NC1_FreeShape.5: Dans le cas où la localisation est un point alors la forme ne peut être ni une ligne ni une zone.</iso:assert>
    </iso:rule>
    <iso:rule context="/nc1pema:NC1_PEMA/intelCollectionMeansPlan/involvedFreeShape/location">
      <iso:assert test="if (polygon or rectangle or circle or ellipse or arcband or corridor) then not(../tacticalData/style/point) and not(../tacticalData/style/line) else true()">NC1_FreeShape.6: Dans le cas où la localisation est un polygone ou un rectangle ou un cercle ou  une ellipse ou un radarc ou un corridor alors la forme ne peut être ni un point ni une ligne.</iso:assert>
    </iso:rule>
    <iso:rule context="/nc1pema:NC1_PEMA/intelCollectionMeansPlan/involvedFreeShape/location/polyline">
      <iso:assert test="not(../../tacticalData/style/point) and not(../../tacticalData/style/area)">NC1_FreeShape.7: Dans le cas où la localisation est une polyligne alors la forme ne peut être ni un point ni une zone.</iso:assert>
    </iso:rule>
    <iso:rule context="/nc1pema:NC1_PEMA/intelCollectionMeansPlan/intelMeans/associatedArea/tacPoint/tacticalData">
      <iso:assert test="if (frSpecificSymbol) then some $symbolCode in ($TacPointFrSpecific//SimpleCodeList/Row/Value[@ColumnRef='code'][SimpleValue=current()/frSpecificSymbol]/../Value[@ColumnRef='codeSymbole']/SimpleValue) satisfies matches(symbolCode,$symbolCode) else some $symbolCode in ($TacPointSymbol//SimpleCodeList/Row/Value[@ColumnRef='codeSymbole']/SimpleValue) satisfies matches(symbolCode,$symbolCode)" diagnostics="D26830-en">NC1_TacPoint.1: Si la spécialisation Fr du code symbole est renseignée alors le code du symbole renseigné doit être celui correspondant à la valeur du dictionnaire des codes symboles spécifiques sinon il doit appartenir à l'une des valeurs du dictionnaire des codes symboles autorisés.</iso:assert>
      <iso:assert test="if (frSpecificSymbol) then true() else some $symbolCode in ($TacPointSymbol//SimpleCodeList/Row/Value[@ColumnRef='code'][SimpleValue&gt;0]/../Value[@ColumnRef='codeSymbole']/SimpleValue) satisfies matches(symbolCode,$symbolCode)">NC1_TacPoint.6: Dans le cas où la spécialisation Fr du code symbole n'est pas renseignée alors le code symbole doit exister et appartenir à l'une des valeurs positives du dictionnaire des codes symboles autorisés.</iso:assert>
    </iso:rule>
    <iso:rule context="/nc1pema:NC1_PEMA/intelCollectionMeansPlan/intelMeans/associatedArea/tacPoint/tacticalData/symbolCode">
      <iso:assert test="some $Pays in ($L105_2//SimpleCodeList/Row/Value[@ColumnRef='short']/SimpleValue) satisfies substring(.,19,2) = substring($Pays,1,2)" diagnostics="D26832-en">NC1_TacPoint.2: Les 13ème et 14ème caractères du Code du symbole doivent correspondre à une valeur du dictionnaire L105_2Code.</iso:assert>
      <iso:assert test="matches(.,':...[AP]')">NC1_TacPoint.7: Le 4ème caractère du Code symbole doit correspondre aux valeurs 'A' ou 'P'.</iso:assert>
    </iso:rule>
    <iso:rule context="/nc1pema:NC1_PEMA/intelCollectionMeansPlan/intelMeans/associatedArea/tacPoint/@id">
      <iso:assert test="matches(.,'^40:')" diagnostics="D26831-en">NC1_TacPoint.4: Le type de l'objet doit avoir pour valeur 40</iso:assert>
    </iso:rule>
    <iso:rule context="/nc1pema:NC1_PEMA/intelCollectionMeansPlan/intelMeans/associatedArea/tacPoint/tacticalData/responsibleUnitId/@id">
      <iso:assert test="matches(.,'^0:')" diagnostics="D26829-en">NC1_TacPoint.5: Le responsable du point tactique doit être une unité (NC1_Unit).</iso:assert>
    </iso:rule>
    <iso:rule context="/nc1pema:NC1_PEMA/intelCollectionMeansPlan/intelMeans/associatedArea/tacLine/tacticalData">
      <iso:assert test="if (frSpecificSymbol) then some $symbolCode in ($TacLineFrSpecific//SimpleCodeList/Row/Value[@ColumnRef='code'][SimpleValue=current()/frSpecificSymbol]/../Value[@ColumnRef='codeSymbole']/SimpleValue) satisfies matches(symbolCode,$symbolCode) else some $symbolCode in ($TacLineSymbol//SimpleCodeList/Row/Value[@ColumnRef='codeSymbole']/SimpleValue) satisfies matches(symbolCode,$symbolCode)" diagnostics="D26892-en">NC1_TacLine.3: Si la spécialisation Fr du code symbole est renseignée alors le code du symbole renseigné doit être celui correspondant à la valeur du dictionnaire des codes symboles spécifiques sinon il doit appartenir à l'une des valeurs du dictionnaire des codes symboles autorisés.</iso:assert>
      <iso:assert test="if (frSpecificSymbol) then true() else some $symbolCode in ($TacLineSymbol//SimpleCodeList/Row/Value[@ColumnRef='code'][SimpleValue&gt;0]/../Value[@ColumnRef='codeSymbole']/SimpleValue) satisfies matches(symbolCode,$symbolCode)">NC1_TacLine.11: Dans le cas où la spécialisation Fr du code symbole n'est pas renseignée alors le code symbole doit exister et appartenir à l'une des valeurs positives du dictionnaire des codes symboles autorisés.</iso:assert>
    </iso:rule>
    <iso:rule context="/nc1pema:NC1_PEMA/intelCollectionMeansPlan/intelMeans/associatedArea/tacLine/tacticalData/symbolCode">
      <iso:assert test="some $Pays in ($L105_2//SimpleCodeList/Row/Value[@ColumnRef='short']/SimpleValue) satisfies substring(.,19,2) = substring($Pays,1,2)" diagnostics="D26898-en">NC1_TacLine.4: Les 13ème et 14ème caractères du Code du symbole doivent correspondre à une valeur du dictionnaire L105_2Code.</iso:assert>
      <iso:assert test="if (matches(., ':G.C.MGLB')) then (../../specificData/leftUnitId or ../../specificData/rightUnitId) else true()" diagnostics="D26893-en">NC1_TacLine.7: Si la ligne tactique est une limite entre unités, l'unité à gauche ou l'unité à droite de la limite doit être renseignée sinon aucune ne doit être renseignée.</iso:assert>
      <iso:assert test="matches(.,':...[AP]')">NC1_TacLine.12: Le 4ème caractère du Code symbole doit correspondre aux valeurs 'A' ou 'P'.</iso:assert>
    </iso:rule>
    <iso:rule context="/nc1pema:NC1_PEMA/intelCollectionMeansPlan/intelMeans/associatedArea/tacLine/@id">
      <iso:assert test="matches(.,'^41:')" diagnostics="D26897-en">NC1_TacLine.6: Le type de l'objet doit avoir pour valeur 41</iso:assert>
    </iso:rule>
    <iso:rule context="/nc1pema:NC1_PEMA/intelCollectionMeansPlan/intelMeans/associatedArea/tacLine/specificData/leftUnitId/@id">
      <iso:assert test="matches(.,'^0:')" diagnostics="D26894-en">NC1_TacLine.8: L'unité à gauche de la limite doit être une unité (NC1_Unit).</iso:assert>
    </iso:rule>
    <iso:rule context="/nc1pema:NC1_PEMA/intelCollectionMeansPlan/intelMeans/associatedArea/tacLine/specificData/rightUnitId/@id">
      <iso:assert test="matches(.,'^0:')" diagnostics="D26895-en">NC1_TacLine.8: L'unité à droite de la limite doit être une unité (NC1_Unit).</iso:assert>
    </iso:rule>
    <iso:rule context="/nc1pema:NC1_PEMA/intelCollectionMeansPlan/intelMeans/associatedArea/tacLine/tacticalData/responsibleUnitId/@id">
      <iso:assert test="matches(.,'^0:')" diagnostics="D26896-en">NC1_TacLine.9: Le responsable de la ligne tactique doit être une unité (NC1_Unit).</iso:assert>
    </iso:rule>
    <iso:rule context="/nc1pema:NC1_PEMA/intelCollectionMeansPlan/intelMeans/associatedArea/tacLine/location/multipoint">
      <iso:assert test="count(point) = 2" diagnostics="D26899-en">NC1_TacLine.10: Le nombre de points pour la localisation de type multipoint est de 2 points.</iso:assert>
    </iso:rule>
    <iso:rule context="/nc1pema:NC1_PEMA/intelCollectionMeansPlan/intelMeans/associatedArea/tacArea/tacticalData">
      <iso:assert test="if (frSpecificSymbol) then some $symbolCode in ($TacAreaFrSpecific//SimpleCodeList/Row/Value[@ColumnRef='code'][SimpleValue=current()/frSpecificSymbol]/../Value[@ColumnRef='codeSymbole']/SimpleValue) satisfies matches(symbolCode,$symbolCode) else some $symbolCode in ($TacAreaSymbol//SimpleCodeList/Row/Value[@ColumnRef='codeSymbole']/SimpleValue) satisfies matches(symbolCode,$symbolCode)" diagnostics="D26902-en">NC1_TacArea.1: Si la spécialisation Fr du code symbole est renseignée alors le code du symbole renseigné doit être celui correspondant à la valeur du dictionnaire des codes symboles spécifiques sinon il doit appartenir à l'une des valeurs du dictionnaire des codes symboles autorisés.</iso:assert>
      <iso:assert test="if (frSpecificSymbol) then true() else some $symbolCode in ($TacAreaSymbol//SimpleCodeList/Row/Value[@ColumnRef='code'][SimpleValue&gt;0]/../Value[@ColumnRef='codeSymbole']/SimpleValue) satisfies matches(symbolCode,$symbolCode)">NC1_TacArea.6: Dans le cas ou la spécialisation Fr du code symbole n'est pas renseigné alors le code symbole doit exister et appartenir à l'une des valeurs positives du dictionnaire des codes symbole autorisés.</iso:assert>
    </iso:rule>
    <iso:rule context="/nc1pema:NC1_PEMA/intelCollectionMeansPlan/intelMeans/associatedArea/tacArea/tacticalData/symbolCode">
      <iso:assert test="some $Pays in ($L105_2//SimpleCodeList/Row/Value[@ColumnRef='short']/SimpleValue) satisfies substring(.,19,2) = substring($Pays,1,2)" diagnostics="D26900-en">NC1_TacArea.2: Les 13ème et 14ème caractères du Code du symbole doivent correspondre à une valeur du dictionnaire L105_2Code.</iso:assert>
      <iso:assert test="matches(.,':...[AP]')">NC1_TacArea.7: Le 4ème caractère du Code symbole doit correspondre aux valeurs 'A' ou 'P'.</iso:assert>
    </iso:rule>
    <iso:rule context="/nc1pema:NC1_PEMA/intelCollectionMeansPlan/intelMeans/associatedArea/tacArea/@id">
      <iso:assert test="matches(.,'^42:')" diagnostics="D26903-en">NC1_TacArea.4: Le type de l'objet doit avoir pour valeur 42.</iso:assert>
    </iso:rule>
    <iso:rule context="/nc1pema:NC1_PEMA/intelCollectionMeansPlan/intelMeans/associatedArea/tacArea/tacticalData/responsibleUnitId/@id">
      <iso:assert test="matches(.,'^0:')" diagnostics="D26901-en">NC1_TacArea.5: Le responsable de la surface tactique doit être une unité (NC1_Unit).</iso:assert>
    </iso:rule>
    <iso:rule context="/nc1pema:NC1_PEMA/intelCollectionMeansPlan/intelMeans/associatedArea/freeShape/tacticalData/style/line/type">
      <iso:assert test=". != 0">NC1_FreeShape.1: Le type de la forme libre de style ligne ne peut être égal à 0.</iso:assert>
    </iso:rule>
    <iso:rule context="/nc1pema:NC1_PEMA/intelCollectionMeansPlan/intelMeans/associatedArea/freeShape/@id">
      <iso:assert test="matches(.,'^44:')" diagnostics="D26752-en">NC1_FreeShape.4: Le type de l'objet doit avoir pour valeur 44</iso:assert>
    </iso:rule>
    <iso:rule context="/nc1pema:NC1_PEMA/intelCollectionMeansPlan/intelMeans/associatedArea/freeShape/location/point">
      <iso:assert test="not(../../tacticalData/style/line) and not(../../tacticalData/style/area)" diagnostics="D26753-en">NC1_FreeShape.5: Dans le cas où la localisation est un point alors la forme ne peut être ni une ligne ni une zone.</iso:assert>
    </iso:rule>
    <iso:rule context="/nc1pema:NC1_PEMA/intelCollectionMeansPlan/intelMeans/associatedArea/freeShape/location">
      <iso:assert test="if (polygon or rectangle or circle or ellipse or arcband or corridor) then not(../tacticalData/style/point) and not(../tacticalData/style/line) else true()">NC1_FreeShape.6: Dans le cas où la localisation est un polygone ou un rectangle ou un cercle ou  une ellipse ou un radarc ou un corridor alors la forme ne peut être ni un point ni une ligne.</iso:assert>
    </iso:rule>
    <iso:rule context="/nc1pema:NC1_PEMA/intelCollectionMeansPlan/intelMeans/associatedArea/freeShape/location/polyline">
      <iso:assert test="not(../../tacticalData/style/point) and not(../../tacticalData/style/area)">NC1_FreeShape.7: Dans le cas où la localisation est une polyligne alors la forme ne peut être ni un point ni une zone.</iso:assert>
    </iso:rule>
    <iso:let name="ObstacleFrSpecific" value="doc('../Dictionnaires/ObstacleFrSpecificCode.gc')" />
    <iso:let name="L105_2" value="doc('../Dictionnaires/L105_2Code.gc')" />
    <iso:let name="ObstacleSymbol" value="doc('../Dictionnaires/ObstacleSymbolCode.gc')" />
    <iso:let name="FacilityFrSpecific" value="doc('../Dictionnaires/FacilityFrSpecificCode.gc')" />
    <iso:let name="FacilitySymbol" value="doc('../Dictionnaires/FacilitySymbolCode.gc')" />
    <iso:let name="UnitFrSpecific" value="doc('../Dictionnaires/UnitFrSpecificCode.gc')" />
    <iso:let name="UnitSymbol" value="doc('../Dictionnaires/UnitSymbolCode.gc')" />
    <iso:let name="TacPointSymbol" value="doc('../Dictionnaires/TacPointSymbolCode.gc')" />
    <iso:let name="TacPointFrSpecific" value="doc('../Dictionnaires/TacPointFrSpecificCode.gc')" />
    <iso:let name="TacLineSymbol" value="doc('../Dictionnaires/TacLineSymbolCode.gc')" />
    <iso:let name="TacLineFrSpecific" value="doc('../Dictionnaires/TacLineFrSpecificCode.gc')" />
    <iso:let name="TacAreaSymbol" value="doc('../Dictionnaires/TacAreaSymbolCode.gc')" />
    <iso:let name="TacAreaFrSpecific" value="doc('../Dictionnaires/TacAreaFrSpecificCode.gc')" />
  </iso:pattern>
  <iso:diagnostics>
    <iso:diagnostic xml:lang="en" id="D26358-en">NC1_Facility.1: If the specialization Fr of the symbol code is filled in then the code of the filled in symbol must be the one corresponding to the value of the dictionary of specific symbol codes otherwise it must belong to one of the values ??of the dictionary of authorized symbol codes.</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26359-en">NC1_Facility.6: When the installation is anticipated, the timestamp of the statement of its position on the ground and the quality of the measure of location should not be informed.</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26360-en">NC1_Facility.7: The responsible of the 3D route shall be a unit (NC1_Unit).</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26361-en">NC1_Facility.8: The person admitted in a medical installation has to be an individual ( NC1_Individual).</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26362-en">NC1_Facility.9: The location of the enemy facility shall be estimated only.</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26363-en">NC1_Facility.5: The type of the object has to have for value 18</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26364-en">NC1_Facility.2: The 13th and 14th characters of the Symbol Code must correspond to a value from the L105_2Code dictionary.</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26682-en">NC1_PEMA.3: The area associated with research facilities should be located.</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26683-en">NC1_PEMA.3: The area associated with research facilities should be located.</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26684-en">NC1_PEMA.3: The area associated with research facilities should be located.</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26685-en">NC1_PEMA.3: The area associated with research facilities should be located.</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26686-en">NC1_PEMA.3: The area associated with research facilities should be located.</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26687-en">NC1_PEMA.2: Any unit in charge of intelligence collection shall be a unit (NC1_Unit).</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26745-en">NC1_GroundParticipant.2: The symbology standard to be used shall be APP-6(B). The symbol code of an obstacle shall be of the following type:  S*G*E*****--*** or S*F*******--*** . Participant identity shall be "ASSUMED FRIEND" or "FRIEND" (A or F in APP6B standard)</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26746-en">NC1_GroundParticipant.5: When the participant is anticipated, the timestamp of the statement of its position on the ground and the quality of the measure of location should not be informed.</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26747-en">NC1_GroundParticipant.7: The participant representing unit shall be a NC1_Unit object.</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26748-en">NC1_GroundParticipant.8: The operational or logistic status of the participant shall be provided.</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26749-en">NC1_GroundParticipant.6: The type of the object has to have for value 9</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26750-en">NC1_GroundParticipant.3: The 13th and 14th characters of the Symbol Code must correspond to a value from the L105_2Code dictionary.</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26751-en">NC1_GroundParticipant.10: The identifier of the aggregating participant must be entered if the presence indicator is True.</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26752-en">NC1_FreeShape.4: The type of the object has to have for value 44</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26753-en">NC1_FreeShape.5: The 13th and 14th characters of the Symbol Code must correspond to a value from the L105_2Code dictionary.</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26754-en">NC1_Obstacle.2: The 13th and 14th characters of the Symbol Code must correspond to a value from the L105_2Code dictionary.</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26755-en">NC1_Obstacle.5: When the obstacle is anticipated, the quality of the measure of location and the timestamp of the statement of its position on the ground must not be informed.</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26756-en">NC1_Obstacle.6: In the case of an enemy obstacle, that is the identity of which is worth « UNKNOWN », « NEUTRAL », « SUSPECT », « HOSTILE », « JOKER », « FAKER » or « NONE SPECIFIED » (U, N, a Hour, J, K, or O in the APP6B), the number of obstacle on 9 characters has to begin with « ENY ».</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26757-en">NC1_Obstacle.7: The obstacle bypass route shall be a NC1_Route object.</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26758-en">NC1_Obstacle.8: The unit responsible for the obstacle shall be a unit of the Order of Battle (NC1_Unit).</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26759-en">NC1_Obstacle.1: If the specialization Fr of the symbol code is filled in then the code of the filled in symbol must be the one corresponding to the value of the dictionary of specific symbol codes otherwise it must belong to one of the values ??of the dictionary of authorized symbol codes.</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26760-en">NC1_Obstacle.9: The location of the enemy obstacle shall be estimated only.</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26761-en">NC1_Obstacle.4: The type of the object has to have for value 17</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26774-en">NC1_Individual.2: The used standard of symbology has to be the APP-6 (B). The code symbol of an individual has to be in families G*C*MGAUA ****** or G*C*MGPI - ***** .</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26775-en">NC1_Individual.6: When the individual is anticipated, the timestamp of the statement of its position on the ground and the quality of the measure of location must not be informed.</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26776-en">NC1_Individual.7: For a friendly individual (FRIEND or ASSUMED FRIEND), the SPI indicator shall not be provided.</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26777-en">NC1_Individual.8: The responsible of the facility shall be a unit (NC1_Unit).</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26778-en">NC1_Individual.9: The NC1 object linked to the facts register shall be an event (NC1_Event).</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26779-en">NC1_Individual.10: The unit the individual belongs to shall be a NC1_Unit object.</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26780-en">NC1_Individual.11: The location of the enemy individual shall be estimated only.</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26781-en">NC1_Individual.5: The type of the object has to have for value 3</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26782-en">NC1_Individual.3: The 13th and 14th characters of the Symbol Code must correspond to a value from the L105_2Code dictionary.</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26783-en">NC1_Organisation.2: The used standard of symbology has to be the APP-6 ( B ). The code symbol of an organization has to be in families S*G*USA ******** or S*G* **--------- .</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26784-en">NC1_Organisation.6: When the organization is anticipated, the timestamp of the statement of its position on the ground and the quality of the measure of location should not be informed.</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26785-en">NC1_Organisation.7: The responsible of the organisation shall be a unit (NC1_Unit).</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26786-en">NC1_Organisation.8: The location of the enemy organisation shall be estimated only.</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26787-en">NC1_Organisation.5: The type of the object has to have for value 2</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26788-en">NC1_Organisation.3: The 13th and 14th characters of the Symbol Code must correspond to a value from the L105_2Code dictionary.</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26789-en">NC1_GroundEntity.2: The type of the object has to have for value 20</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26790-en">NC1_IntelRequirement.3: The intelligence need shall be localized through a tactical point (NC1_TacPoint), a tactical line (NC1_TacLine), a tactical area (NC1_TacArea), or graphic shape.</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26791-en">NC1_IntelRequirement.3: The intelligence need shall be localized through a tactical point (NC1_TacPoint), a tactical line (NC1_TacLine), a tactical area (NC1_TacArea), or graphic shape.</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26792-en">NC1_IntelRequirement.3: The intelligence need shall be localized through a tactical point (NC1_TacPoint), a tactical line (NC1_TacLine), a tactical area (NC1_TacArea), or graphic shape.</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26793-en">NC1_IntelRequirement.2: The type of the object has to have for value 39</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26794-en">NC1_CbrnEvent.2: The symbol code of a CBRN event shall be of the following type:  G*C*BW********* .</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26795-en">NC1_CbrnEvent.5: The type of the object has to have for value 31</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26796-en">NC1_CbrnEvent.3: The 13th and 14th characters of the Symbol Code must correspond to a value from the L105_2Code dictionary.</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26821-en">NC1_Event.2: The used standard of symbology has to be the APP-6 (B). The code symbol of an event has to be in the family G*O ************ .</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26822-en">NC1_Event.6: When the event is anticipated, the location measurement quality shall not be provided.</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26823-en">NC1_Event.8: The actor having caused the event has to be an agent (NC1_Unit, NC1_Organisation or NC1_Individual).</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26824-en">NC1_Event.8: The actor involved in the event has to be an agent (NC1_Unit, NC1_Organisation or NC1_Individual).</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26825-en">NC1_Event.7: The responsible of the management of the event shall be a unit (NC1_Unit).</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26826-en">NC1_Event.9: The location of the enemy event shall be estimated only.</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26827-en">NC1_Event.5: The type of the object has to have for value 30</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26828-en">NC1_Event.3: The 13th and 14th characters of the Symbol Code must correspond to a value from the L105_2Code dictionary.</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26829-en">NC1_TacPoint.5: The responsible of the tactical point shall be a unit (NC1_Unit).</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26830-en">NC1_TacPoint.1: If the specialization Fr of the symbol code is filled in then the code of the filled in symbol must be the one corresponding to the value of the dictionary of specific symbol codes otherwise it must belong to one of the values ??of the dictionary of authorized symbol codes.</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26831-en">NC1_TacPoint.4: The type of the object has to have for value 40</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26832-en">NC1_TacPoint.2: The 13th and 14th characters of the Symbol Code must correspond to a value from the L105_2Code dictionary.</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26848-en">NC1_Convoy.2: The used standard of symbology has to be the APP-6 ( B ). The code symbol of a convoy has to be in the family G*C*SLC ******** .</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26849-en">NC1_Convoy.7: If the convoy is anticipated, the timestamp of the statement of its position on the ground and the quality of the measure of location must not be informed.</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26850-en">NC1_Convoy.8: The members of a convoy have to be agents (NC1_Unit, NC1_Organisation or NC1_Individual).</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26851-en">NC1_Convoy.9: The route associated to the movement shall be a NC1_Route object.</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26852-en">NC1_Convoy.10: The location of the enemy convoy shall be estimated only.</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26853-en">NC1_Convoy.6: The type of the object has to have for value 16</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26854-en">NC1_Convoy.3: The 13th and 14th characters of the Symbol Code must correspond to a value from the L105_2Code dictionary.</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26855-en">NC1_Route.2: The used standard of symbology has to be the APP-6 ( B ). The code symbol of a point on a route has to be in the family G*C*OG ********* .</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26856-en">NC1_Route.2: The used standard of symbology has to be the APP-6 ( B ). The code symbol of a point on a route has to be in the family G*C*OG ********* .</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26857-en">NC1_Route.6: The route start point ID shall be the ID of a tactical point (NC1_TacPoint).</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26858-en">NC1_Route.6: The route end point ID shall be the ID of a tactical point (NC1_TacPoint).</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26859-en">NC1_Route.7: The ground entity associated to a route section shall be a NC1_GroundEntity object.</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26860-en">NC1_Route.5: The type of the object has to have for value 38</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26861-en">NC1_Route.4: The 13th and 14th characters of the Code of the starting point symbol must correspond to a value from the L105_2Code dictionary.</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26862-en">NC1_Route.4: The 13th and 14th characters of the Code of the symbol of the end point must correspond to a value from the L105_2Code dictionary.</iso:diagnostic>
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
    <iso:diagnostic xml:lang="en" id="D26892-en">NC1_TacLine.3: If the specialization Fr of the symbol code is filled in then the code of the filled in symbol must be the one corresponding to the value of the dictionary of specific symbol codes otherwise it must belong to one of the values ??of the dictionary of authorized symbol codes.</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26893-en">NC1_TacLine.7: If the tactical line is a limit between units, unit to the left or unit to the right of the limit shall be provided else none must be provided.</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26894-en">NC1_TacLine.8: The unit to the left of the limit shall be a unit (NC1_Unit).</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26895-en">NC1_TacLine.8: The unit to the right of the limit shall be a unit (NC1_Unit).</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26896-en">NC1_TacLine.9: The responsible of the tactical line shall be a unit (NC1_Unit).</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26897-en">NC1_TacLine.6: The type of the object has to have for value 41</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26898-en">NC1_TacLine.4: The 13th and 14th characters of the Symbol Code must correspond to a value from the L105_2Code dictionary.</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26899-en">NC1_TacLine.10: The number of points for multipoint type localization is 2 points.</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26900-en">NC1_TacArea.2: The 13th and 14th characters of the Symbol Code must correspond to a value from the L105_2Code dictionary.</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26901-en">NC1_TacArea.5: The responsible of the tactical area shall be a unit (NC1_Unit).</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26902-en">NC1_TacArea.1: If the specialization Fr of the symbol code is filled in then the code of the filled in symbol must be the one corresponding to the value of the dictionary of specific symbol codes otherwise it must belong to one of the values ??of the dictionary of authorized symbol codes.</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26903-en">NC1_TacArea.4: The type of the object has to have for value 42</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26904-en">NC1_SeaTrack.2: The used standard of symbology has to be the APP-6 ( B ). The code symbol of a maritime track has to be in the family S*S ************.</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26905-en">NC1_SeaTrack.6: When the track is anticipated, the timestamp of the statement of its position on the ground and the quality of the measure of location must not be informed.</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26906-en">NC1_SeaTrack.8: The unit the track belongs to shall be a NC1_Unit object.</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26907-en">NC1_SeaTrack.9: The location of the enemy track shall be estimated only.</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26908-en">NC1_SeaTrack.7: The responsible for the handling of the track shall be a unit (NC1_Unit).</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26909-en">NC1_SeaTrack.5: The type of the object has to have for value 13</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26910-en">NC1_SeaTrack.3: The 13th and 14th characters of the Symbol Code must correspond to a value from the L105_2Code dictionary.</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26911-en">NC1_GroundTrack.3: The used standard of symbology has to be the APP-6 ( B ). The code symbol of a ground track has to be in families S*G*E********** or S*F*G********** except S*F*GB*********.</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26912-en">NC1_GroundTrack.6: When the track is anticipated, the timestamp of the statement of its position and the quality of the measure of location on the ground should not be informed.</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26913-en">NC1_GroundTrack.8: The unit the track belongs to shall shall be a unit (NC1_Unit).</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26914-en">NC1_GroundTrack.9: The location of the enemy track shall be estimated only.</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26915-en">NC1_GroundTrack.7: The responsible for the handling of the track shall be a unit (NC1_Unit).</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26916-en">NC1_GroundTrack.5: The type of the object has to have for value 12</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26917-en">NC1_GroundTrack.4: The 13th and 14th characters of the Symbol Code must correspond to a value from the L105_2Code dictionary.</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26918-en">NC1_AirTrack.3: The used standard of symbology has to be the APP-6 ( B ). The code symbol of an air track has to be in the family S*A ************.</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26919-en">NC1_AirTrack.6: When the track is anticipated, the quality of the measure of location and the timestamp of the statement of its position on the ground should not be informed.</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26920-en">NC1_AirTrack.8: The unit the track belongs to shall be a NC1_Unit object.</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26921-en">NC1_AirTrack.9: The location of the enemy track shall be estimated only.</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26922-en">NC1_AirTrack.7: The responsible for the handling of the track shall be a unit (NC1_Unit).</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26923-en">NC1_AirTrack.5: The type of the object has to have for value 15</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26924-en">NC1_AirTrack.4: The 13th and 14th characters of the Symbol Code must correspond to a value from the L105_2Code dictionary.</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26925-en">NC1_AirParticipant.2: "The used standard of symbology has to be the APP-6 (B). The code symbol of an air participant has to be in families S*A ******* - *** and the identity of a participant owes ""being ASSUMED FRIEND"", or ""FRIEND"" (In or F in the APP6B)".</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26926-en">NC1_AirParticipant.4: When the participant is anticipated, the timestamp of the statement of its position on the ground and the quality of the measure of location should not be informed.</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26927-en">NC1_AirParticipant.7: The participant representing unit shall be a NC1_Unit object.</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26928-en">NC1_AirParticipant.8: The operational or logistic status of the participant shall be provided.</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26929-en">NC1_AirParticipant.6: The type of the object has to have for value 11</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26930-en">NC1_AirParticipant.5: The 13th and 14th characters of the Symbol Code must correspond to a value from the L105_2Code dictionary.</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26931-en">NC1_AirParticipant.10: The identifier of the aggregating participant must be entered if the presence indicator is True.</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26932-en">NC1_SeaParticipant.2: "The used standard of symbology has to be the APP-6 (B). The code symbol of a maritime participant has to be in families S*S ******* - ***. The identity of a participant owes ""being ASSUMED FRIEND"", or ""FRIEND"" (In or F in the APP6B)".</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26933-en">NC1_SeaParticipant.5: When the participant is anticipated, the timestamp of the statement of its position on the ground and the quality of the measure of location should not be informed.</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26934-en">NC1_SeaParticipant.7: The participant representing unit shall be a NC1_Unit object.</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26935-en">NC1_SeaParticipant.8: The operational or logistic status of the participant shall be provided.</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26936-en">NC1_SeaParticipant.6: The type of the object has to have for value 10</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26937-en">NC1_SeaParticipant.3: The 13th and 14th characters of the Symbol Code must correspond to a value from the L105_2Code dictionary.</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26938-en">NC1_SeaParticipant.10: The identifier of the aggregating participant must be entered if the presence indicator is True.</iso:diagnostic>
  </iso:diagnostics>
</iso:schema>
﻿<?xml version="1.0" encoding="utf-8"?>
<iso:schema queryBinding="xslt2" xmlns:iso="http://purl.oclc.org/dsdl/schematron">
  <!-- NC1 V.9.0.0 -->
  <iso:ns uri="http://www.w3.org/2001/XMLSchema-instance" prefix="xsi" />
  <iso:ns uri="urn:fra:nc1:message:firecontrol" prefix="nc1firecontrol" />
  <iso:pattern>
    <iso:title>NC1_FireControl validation rules</iso:title>
    <iso:rule context="/nc1firecontrol:NC1_FireControl/@situation">
      <iso:assert test=". = 'STC'" diagnostics="D26494-en">NC1_FireControl.2: La situation de ce message doit être STC (Situation Tactique Courante).</iso:assert>
    </iso:rule>
    <iso:rule context="/nc1firecontrol:NC1_FireControl/fireMissionCommand/fire/@instance">
      <iso:assert test=". = 'STC'" diagnostics="D26500-en">NC1_FireControl.3: L'instance du tir doit valoir STC (Situation Tactique Courante).</iso:assert>
    </iso:rule>
    <iso:rule context="/nc1firecontrol:NC1_FireControl/fireMissionCommand/fire/tacticalData">
      <iso:assert test="not(comment) and not(name) and not(status)" diagnostics="D26501-en">NC1_FireControl.3: Le commentaire, le nom et l'état du tir ne doivent pas être renseignés.</iso:assert>
    </iso:rule>
    <iso:rule context="/nc1firecontrol:NC1_FireControl/fireMissionCommand/fire/callForFireData">
      <iso:assert test="count(adjustmentFire/adjustmentPoint) + count(fireForEffect/location) + count(tacticalEffect) + count(ammunitionEffect) + count(../executiveReport) = 0" diagnostics="D26498-en">NC1_FireControl.4: Le point de réglage MEP, la localisation du tir d'efficacité, l'effet tactique et l'effet munition et le bilan exécutants du  tir ne doivent pas être renseignés.</iso:assert>
      <iso:assert test="if ((adjustmentFire/controlMethod = '4') or (fireForEffect/controlMethod = '4')) then count(actors/responsibleAuthorityId) &gt; 0 else count(actors/responsibleAuthorityId) = 0" diagnostics="D26802-en">NC1_Fire.5: L'autorité reponsable du tir doit être renseignée si la méthode de contrôle MEP ou EFF est « Au Commandement Autorité », sinon elle ne doit pas être renseignée.</iso:assert>
      <iso:assert test="if (tacticalEffect/requiredEffect=('2','3','4')) then effectDuration else not(effectDuration)" diagnostics="D26813-en">NC1_Fire.10: Si l'effet à obtenir est 2 (Aveugler dans le visible), 3 (Illuminer), ou 4 (Illuminer dans l'IR), alors la durée de l'effet doit être renseignée.</iso:assert>
    </iso:rule>
    <iso:rule context="/nc1firecontrol:NC1_FireControl/fireMissionCommand">
      <iso:assert test="if (missionCommandType=('5', '6')) then count(fire/callForFireData/adjustmentFire)=0 else if (missionCommandType='4') then count(fire/callForFireData/fireForEffect)=0 else count(fire/callForFireData/adjustmentFire)+count(fire/callForFireData/fireForEffect)=0" diagnostics="D26495-en">NC1_FireControl.5: Lorsque le type de directive ne vaut pas 5(« EFF ») ou 6(« Renouveller EFF »), les données relatives à un tir d'efficacité ne doivent pas être renseignées. Lorsque le type de directive ne vaut pas 4 (« MEP »), les données relatives à un tir de mise en place ne doivent pas être renseignées.</iso:assert>
    </iso:rule>
    <iso:rule context="/nc1firecontrol:NC1_FireControl/fireMissionCommand/adjustment">
      <iso:assert test="count(NS) + count(EW) + count(Z) &gt; 0" diagnostics="D26496-en">NC1_FireControl.6: Au moins un réglage Nord-Sud, Est-Ouest ou vertical doit être renseigné.</iso:assert>
    </iso:rule>
    <iso:rule context="/nc1firecontrol:NC1_FireControl/fireMissionCommand/missionCommandType">
      <iso:assert test="if ( . = ('4', '5', '6')) then true() else count(../adjustment)=0" diagnostics="D26497-en">NC1_FireControl.7: Si le tir n'est pas un tir de mise en place, d'efficacité ou de renouvellement d'efficacité, le réglage ne doit pas être renseigné.</iso:assert>
    </iso:rule>
    <iso:rule context="/nc1firecontrol:NC1_FireControl/fireMissionCommand/fire/@isFull">
      <iso:assert test=". = '0'" diagnostics="D26499-en">NC1_FireControl.8: L'objet tir ne doit pas être complet.</iso:assert>
    </iso:rule>
    <iso:rule context="/nc1firecontrol:NC1_FireControl/fireMissionCommand/fire/callForFireData/fireForEffect/location/polyline">
      <iso:assert test="count(point) = 2" diagnostics="D26797-en">NC1_Fire.1: La forme polyline doit comporter exactement 2 points.</iso:assert>
    </iso:rule>
    <iso:rule context="/nc1firecontrol:NC1_FireControl/fireMissionCommand/fire/@id">
      <iso:assert test="matches(.,'^37:')" diagnostics="D26819-en">NC1_Fire.3: Le type de l'objet doit avoir pour valeur 37</iso:assert>
    </iso:rule>
    <iso:rule context="/nc1firecontrol:NC1_FireControl/fireMissionCommand/fire/callForFireData/actors/executantEntityId/@id">
      <iso:assert test="matches(.,'^(0|9|10|11):')" diagnostics="D26801-en">NC1_Fire.4: Un exécutant intervenant sur un tir doit être une unité (objet NC1_Unit)</iso:assert>
    </iso:rule>
    <iso:rule context="/nc1firecontrol:NC1_FireControl/fireMissionCommand/fire/callForFireData/actors/otherEntityId/@id">
      <iso:assert test="matches(.,'^(0|9|10|11):')" diagnostics="D26799-en">NC1_Fire.4: Un acteur intervenant sur un tir doit être une unité (objet NC1_Unit) ou un participant (objet NC1_Participant).</iso:assert>
    </iso:rule>
    <iso:rule context="/nc1firecontrol:NC1_FireControl/fireMissionCommand/fire/callForFireData/actors/requestingEntityId/@id">
      <iso:assert test="matches(.,'^(0|9|10|11):')" diagnostics="D26798-en">NC1_Fire.4: Le demandeur du tir doit être une unité (objet NC1_Unit) ou un participant (objet NC1_Participant).</iso:assert>
    </iso:rule>
    <iso:rule context="/nc1firecontrol:NC1_FireControl/fireMissionCommand/fire/callForFireData/actors/responsibleAuthorityId/@id">
      <iso:assert test="matches(.,'^(0|9|10|11):')" diagnostics="D26800-en">NC1_Fire.4: L'autorité responsable du tir doit être une unité (objet NC1_Unit) ou un participant (objet NC1_Participant).</iso:assert>
    </iso:rule>
    <iso:rule context="/nc1firecontrol:NC1_FireControl/fireMissionCommand/fire/callForFireData/adjustmentFire">
      <iso:assert test="if (controlMethod = ('2', '3')) then period else not(period)" diagnostics="D26804-en">NC1_Fire.6: Un horodatage (période) du tir de mise en place est nécessaire pour les méthodes de contrôle du tir HSO (Heure Sur Objectif) ou HDT (A l'Heure), sinon l'horodatage ne doit pas être renseigné.</iso:assert>
    </iso:rule>
    <iso:rule context="/nc1firecontrol:NC1_FireControl/fireMissionCommand/fire/callForFireData/fireForEffect">
      <iso:assert test="if (controlMethod = ('2', '3')) then period else not(period)" diagnostics="D26803-en">NC1_Fire.6: Un horodatage (période) du tir d'efficacité est nécessaire pour les méthodes de contrôle du tir HSO (Heure Sur Objectif) ou HDT (A l'Heure), sinon l'horodatage ne doit pas être renseigné.</iso:assert>
      <iso:assert test="if (controlMethod = '0') then true() else count(synchronizedFireId)=0" diagnostics="D26811-en">NC1_Fire.7: Si la méthode de contrôle de tir d'efficacité n'est pas 0 (« AMC » A Mon Commandement), alors le tir ne peut pas être synchronisé avec un autre tir.</iso:assert>
    </iso:rule>
    <iso:rule context="/nc1firecontrol:NC1_FireControl/fireMissionCommand/fire/callForFireData/fireForEffect/synchronizedFireId/@id">
      <iso:assert test="matches(.,'^37:')" diagnostics="D26817-en">NC1_Fire.8: Le tir avec lequel une synchronisation est souhaitée doit être un tir (NC1_Fire).</iso:assert>
    </iso:rule>
    <iso:rule context="/nc1firecontrol:NC1_FireControl/fireMissionCommand/fire/callForFireData/adjustmentFire/adjustmentPoint">
      <iso:assert test="count(z)&gt;0" diagnostics="D26810-en">NC1_Fire.9: L'altitude (z) doit être renseignée.</iso:assert>
    </iso:rule>
    <iso:rule context="/nc1firecontrol:NC1_FireControl/fireMissionCommand/fire/callForFireData/fireForEffect/location/circle/center">
      <iso:assert test="count(z)&gt;0" diagnostics="D26809-en">NC1_Fire.9: L'altitude (z) doit être renseignée.</iso:assert>
    </iso:rule>
    <iso:rule context="/nc1firecontrol:NC1_FireControl/fireMissionCommand/fire/callForFireData/fireForEffect/location/point">
      <iso:assert test="count(z)&gt;0" diagnostics="D26808-en">NC1_Fire.9: L'altitude (z) doit être renseignée.</iso:assert>
    </iso:rule>
    <iso:rule context="/nc1firecontrol:NC1_FireControl/fireMissionCommand/fire/callForFireData/fireForEffect/location/pointsMultiples/point">
      <iso:assert test="count(z)&gt;0" diagnostics="D26806-en">NC1_Fire.9: L'altitude (z) doit être renseignée.</iso:assert>
    </iso:rule>
    <iso:rule context="/nc1firecontrol:NC1_FireControl/fireMissionCommand/fire/callForFireData/fireForEffect/location/polyline/point">
      <iso:assert test="count(z)&gt;0" diagnostics="D26805-en">NC1_Fire.9: L'altitude (z) doit être renseignée.</iso:assert>
    </iso:rule>
    <iso:rule context="/nc1firecontrol:NC1_FireControl/fireMissionCommand/fire/callForFireData/fireForEffect/location/rectangle/center">
      <iso:assert test="count(z)&gt;0" diagnostics="D26807-en">NC1_Fire.9: L'altitude (z) doit être renseignée.</iso:assert>
    </iso:rule>
    <iso:rule context="/nc1firecontrol:NC1_FireControl/fireMissionCommand/fire/callForFireData/ammunitionEffect/requestedAmmunition">
      <iso:assert test="if (type=('1', '3', '4')) then count(../../effectDuration) + count(shotsCount) = 1 else true()" diagnostics="D26812-en">NC1_Fire.10: Si le type de munition demandé est 1 (« Fumigène »), 3(« Eclairante »), ou 4(« Eclairante dans l'IR »), alors soit la durée de l'effet, soit le nombre de coups est renseigné.</iso:assert>
    </iso:rule>
    <iso:rule context="/nc1firecontrol:NC1_FireControl/fireMissionCommand/fire/callForFireData/tacticalEffect/targetData/targetId/@id">
      <iso:assert test="matches(.,'^36:')" diagnostics="D26814-en">NC1_Fire.11: La cible doit être un objectif feux (NC1_FireObjective).</iso:assert>
    </iso:rule>
    <iso:rule context="/nc1firecontrol:NC1_FireControl/fireMissionCommand/fire/callForFireData/ammunitionEffect">
      <iso:assert test="if (requestedAmmunition/type='6') then (count(requestedAmmunition)=1) else true()" diagnostics="D26820-en">NC1_Fire.12: Lorsque la munition demandée est de type 6 (LRU), alors le panachage est impossible.</iso:assert>
      <iso:assert test="if (requestedAmmunition/type='6') then requestedAmmunition/shotsCount&lt;7 else not(surfaceLRU) and requestedAmmunition/triggerMode" diagnostics="D26815-en">NC1_Fire.13: Lorsque la munition demandée est de type 6 (LRU), alors le nombre de coups est limité à 6 ou moins. Lorsque la munition demandée n'est pas de type LRU, le surfacique LRU (ouvert ou fermé) ne doit pas être renseigné mais le mode de déclenchement doit l'être.</iso:assert>
      <iso:assert test="if (count(surfaceLRU)=1) then (requestedAmmunition/shotsCount&gt;1) else true()" diagnostics="D26816-en">NC1_Fire.14: Pour un surfacique LRU le nombre de coups doit être supérieur ou égal à 2.</iso:assert>
    </iso:rule>
  </iso:pattern>
  <iso:diagnostics>
    <iso:diagnostic xml:lang="en" id="D26494-en">NC1_FireControl.2: The context of this message owes being STC (Current Tactical Situation).</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26495-en">NC1_FireControl.5: When the type of directive is not worth 5 (« EFF ») or 6 (« Renouveller EFF »), the data relative to a shooting of efficiency must not be informed. When the type of directive is not worth 4 (« MEP »), the data relative to a shooting of implementation must not be informed.</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26496-en">NC1_FireControl.6: North-South, East-West or vertical adjustment shall be provided.</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26497-en">NC1_FireControl.7: If the fire is not an adjust fire, fire for effect or repeat fire, the adjustment shall not be provided.</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26498-en">NC1_FireControl.4: The ajustement point of regulation, the location of the shooting of efficiency, the tactical effect and the effect ammunition and the balance sheet performers of the shooting should not be informed.</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26499-en">NC1_FireControl.8: The ajustement point of regulation, the location of the shooting of efficiency, the tactical effect and the effect ammunition and the balance sheet performers of the shooting should not be informed.</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26500-en">NC1_FireControl.3: The fire context shall be STC.</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26501-en">NC1_FireControl.3: The comment related to the fire shall not be provided.</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26797-en">NC1_Fire.1: The polyline shape must contain exactly 2 points.</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26798-en">NC1_Fire.4: The requester of the fire shall be a unit (NC1_Unit) or a participant (NC1_Participant).</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26799-en">NC1_Fire.4: Any agent involved in a fire shall be a unit (NC1_Unit object) or a participant (NC1_Participant object).</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26800-en">NC1_Fire.4: The responsible authority of the fire shall be a unit (NC1_Unit) or a participant (NC1_Participant).</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26801-en">NC1_Fire.4: Any agent involved in a fire shall be a unit (NC1_Unit object)</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26802-en">NC1_Fire.5: The reponsable authority of the shooting must be informed if the checking procedure MEP or EFF is « In the Command Authority », otherwise she must not be informed.</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26803-en">NC1_Fire.6: A period or time shall be provided when control method is « TITOTARG » (time to target) or « TITOFIRE » (time to fire).</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26804-en">NC1_Fire.6: A period or time shall be provided when control method is « TITOTARG » (time to target) or « TITOFIRE » (time to fire).</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26805-en">NC1_Fire.9: The altitude (z) shall be provided.</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26806-en">NC1_Fire.9: The altitude (z) shall be provided.</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26807-en">NC1_Fire.9: The altitude (z) shall be provided.</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26808-en">NC1_Fire.9: The altitude (z) shall be provided.</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26809-en">NC1_Fire.9: The altitude (z) shall be provided.</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26810-en">NC1_Fire.9: The altitude (z) shall be provided.</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26811-en">NC1_Fire.7: If the method of control of shooting of efficiency is not 0 (« AMC » Has My Command), then the shooting cannot be synchronized with another shooting.</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26812-en">NC1_Fire.10: If the wanted type of ammunition is 1 (« Smoke »), 3 (« Enlightening »), or 4 (« Enlightening in the IR »), then either the duration of the effect, or the number of blows is informed.</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26813-en">NC1_Fire.10: If the effect to be obtained is 2 (Blind in the visible), 3 (Illuminate), or 4 (Illuminate in the IR), then the duration of the effect must be informed.</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26814-en">NC1_Fire.11: The target must be a fire objective (NC1_FireObjective).</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26815-en">NC1_Fire.13: When the wanted ammunition is type 6 ( LRU), then the number of knocks is limited to 6 or less. When the wanted ammunition is not of type LRU, surface LRU (opened or closed) must not be informed.</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26816-en">NC1_Fire.14: For a MLRS target area, the number of shots shall be at least 2.</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26817-en">NC1_Fire.8: The firing with which a synchronization is wished has to be a firing (NC1_Fire).</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26818-en">NC1_Fire.2: The object context shall be STC.</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26819-en">NC1_Fire.3: The type of the object has to have for value 37</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26820-en">NC1_Fire.12: When the wanted ammunition is type 6 ( LRU), then the mixing is impossible.</iso:diagnostic>
  </iso:diagnostics>
</iso:schema>
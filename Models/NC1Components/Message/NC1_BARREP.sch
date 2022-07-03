<?xml version="1.0" encoding="utf-8"?>
<iso:schema queryBinding="xslt2" xmlns:iso="http://purl.oclc.org/dsdl/schematron">
  <!-- NC1 V.9.0.0 -->
  <iso:ns uri="http://www.w3.org/2001/XMLSchema-instance" prefix="xsi" />
  <iso:ns uri="urn:fra:nc1:message:barrep" prefix="nc1barrep" />
  <iso:pattern>
    <iso:title>NC1_BARREP validation rules</iso:title>
    <iso:rule context="/nc1barrep:NC1_BARREP/friendlyObstacles/friendlyObstacle/tacticalData/symbolCode">
      <iso:assert test="matches(.,'^APP6B:.[AF]')" diagnostics="D26717-en">NC1_BARREP.2: Dans le paragraphe « Obstacles amis », l'identité des obstacles amis doit valoir « ASSUMED FRIEND », ou « FRIEND » (A ou F dans l'APP6B).</iso:assert>
      <iso:assert test="some $Pays in ($L105_2//SimpleCodeList/Row/Value[@ColumnRef='short']/SimpleValue) satisfies substring(.,19,2) = substring($Pays,1,2)" diagnostics="D26754-en">NC1_Obstacle.2: Les 13ème et 14ème caractères du Code du symbole doivent correspondre à une valeur du dictionnaire L105_2Code.</iso:assert>
      <iso:assert test="if (matches(.,':...A')) then count(../../location/quality) + count(../../location/datetime) = 0 else true()" diagnostics="D26755-en">NC1_Obstacle.5: Lorsque l'obstacle est anticipé, la qualité de la mesure de localisation et l'horodatage du relevé de sa position sur le terrain ne doivent pas être renseignés.</iso:assert>
      <iso:assert test="if (matches(.,':.[SHJK]')) then (../../location/quality=1 or not(../../location/quality)) else true()" diagnostics="D26760-en">NC1_Obstacle.9: La localisation d'un obstacle ennemi ne peut qu'être estimée.</iso:assert>
      <iso:assert test="matches(.,':...[AP]')">NC1_Obstacle.11: Le 4ème caractère du Code symbole doit correspondre aux valeurs 'A' ou 'P'.</iso:assert>
    </iso:rule>
    <iso:rule context="/nc1barrep:NC1_BARREP/friendlyObstacles/friendlyObstacle/tacticalData">
      <iso:assert test="if (frSpecificSymbol) then some $symbolCode in ($ObstacleFrSpecific//SimpleCodeList/Row/Value[@ColumnRef='code'][SimpleValue=current()/frSpecificSymbol]/../Value[@ColumnRef='codeSymbole']/SimpleValue) satisfies matches(symbolCode,$symbolCode) else some $symbolCode in ($ObstacleSymbol//SimpleCodeList/Row/Value[@ColumnRef='codeSymbole']/SimpleValue) satisfies matches(symbolCode,$symbolCode)" diagnostics="D26759-en">NC1_Obstacle.1: Si la spécialisation Fr du code symbole est renseignée alors le code du symbole renseigné doit être celui correspondant à la valeur du dictionnaire des codes symboles spécifiques sinon il doit appartenir à l'une des valeurs du dictionnaire des codes symboles autorisés.</iso:assert>
      <iso:assert test="if (frSpecificSymbol) then true() else some $symbolCode in ($ObstacleSymbol//SimpleCodeList/Row/Value[@ColumnRef='code'][SimpleValue&gt;0]/../Value[@ColumnRef='codeSymbole']/SimpleValue) satisfies matches(symbolCode,$symbolCode)">NC1_Obstacle.10: Dans le cas où la spécialisation Fr du code symbole n'est pas renseignée alors le code symbole doit exister et appartenir à l'une des valeurs positives du dictionnaire des codes symboles autorisés.</iso:assert>
    </iso:rule>
    <iso:rule context="/nc1barrep:NC1_BARREP/friendlyObstacles/friendlyObstacle/@id">
      <iso:assert test="matches(.,'^17:')" diagnostics="D26761-en">NC1_Obstacle.4: Le type de l'objet doit avoir pour valeur 17</iso:assert>
    </iso:rule>
    <iso:rule context="/nc1barrep:NC1_BARREP/friendlyObstacles/friendlyObstacle/tacticalData/number9">
      <iso:assert test="if (matches(../symbolCode, ':.F')) then matches(., '^FR[A-Z0-9]{4}[0-9]{3}') else true()" diagnostics="D26756-en">NC1_Obstacle.6: Dans le cas ou le symbole code représente un obstacle ami (2nde lettre du symbolCode = 'F') alors le numéro d'obstacle doit suivre le masque suivant : FR puis alphanumérique sur 4 caractères puis numérique sur 3 caractères.</iso:assert>
      <iso:assert test="if (matches(../symbolCode, ':.H')) then matches(., '^ENY [0-9]{5}') else true()">NC1_Obstacle.6: Dans le cas ou le symbole code représente un obstacle ennemi (2nde lettre du symbolCode = 'H') alors le numéro d'obstacle doit suivre le masque suivant : 'ENY ' puis numérique sur 5 caractères.</iso:assert>
      <iso:assert test="if (matches(../symbolCode, ':.[U]')) then matches(., '^UNK [0-9]{5}') else true()">NC1_Obstacle.6: Dans le cas ou le symbole code représente un obstacle inconnu ami (2nde lettre du symbolCode = 'U') alors le numéro d'obstacle doit suivre le masque suivant : 'UNK ' puis numérique sur 5 caractères.</iso:assert>
      <iso:assert test="if (matches(../symbolCode, ':.[FUH]')) then true() else false()">NC1_Obstacle.6: Le symbole code doit représenter soit un obstacle ami (2nde lettre du symbolCode = 'F') soit un obstacle ennemi (2nde lettre du symbolCode = 'H') soit un obstacle inconnu (2nde lettre du symbolCode = 'U').</iso:assert>
    </iso:rule>
    <iso:rule context="/nc1barrep:NC1_BARREP/friendlyObstacles/friendlyObstacle/tacticalData/bypassRouteId/@id">
      <iso:assert test="matches(.,'^38:')" diagnostics="D26757-en">NC1_Obstacle.7: L'itinéraire de contournement de l'obstacle doit être un objet NC1_Route.</iso:assert>
    </iso:rule>
    <iso:rule context="/nc1barrep:NC1_BARREP/friendlyObstacles/friendlyObstacle/tacticalData/responsibleUnitId/@id">
      <iso:assert test="matches(.,'^0:')" diagnostics="D26758-en">NC1_Obstacle.8: L'unité responsable de l'obstacle doit être une unité de l'Ordre de Bataille ami (NC1_Unit).</iso:assert>
    </iso:rule>
    <iso:let name="ObstacleFrSpecific" value="doc('../Dictionnaires/ObstacleFrSpecificCode.gc')" />
    <iso:let name="L105_2" value="doc('../Dictionnaires/L105_2Code.gc')" />
    <iso:let name="ObstacleSymbol" value="doc('../Dictionnaires/ObstacleSymbolCode.gc')" />
  </iso:pattern>
  <iso:diagnostics>
    <iso:diagnostic xml:lang="en" id="D26717-en">NC1_BARREP.2: In the paragraph « friendly Obstacles », the identity of the friendly obstacles has to be worth « ASSUMED FRIEND » or « FRIEND » (In or F in the APP6B).</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26754-en">NC1_Obstacle.2: The 13th and 14th characters of the Symbol Code must correspond to a value from the L105_2Code dictionary.</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26755-en">NC1_Obstacle.5: When the obstacle is anticipated, the quality of the measure of location and the timestamp of the statement of its position on the ground must not be informed.</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26756-en">NC1_Obstacle.6: In the case of an enemy obstacle, that is the identity of which is worth « UNKNOWN », « NEUTRAL », « SUSPECT », « HOSTILE », « JOKER », « FAKER » or « NONE SPECIFIED » (U, N, a Hour, J, K, or O in the APP6B), the number of obstacle on 9 characters has to begin with « ENY ».</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26757-en">NC1_Obstacle.7: The obstacle bypass route shall be a NC1_Route object.</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26758-en">NC1_Obstacle.8: The unit responsible for the obstacle shall be a unit of the Order of Battle (NC1_Unit).</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26759-en">NC1_Obstacle.1: If the specialization Fr of the symbol code is filled in then the code of the filled in symbol must be the one corresponding to the value of the dictionary of specific symbol codes otherwise it must belong to one of the values ??of the dictionary of authorized symbol codes.</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26760-en">NC1_Obstacle.9: The location of the enemy obstacle shall be estimated only.</iso:diagnostic>
    <iso:diagnostic xml:lang="en" id="D26761-en">NC1_Obstacle.4: The type of the object has to have for value 17</iso:diagnostic>
  </iso:diagnostics>
</iso:schema>
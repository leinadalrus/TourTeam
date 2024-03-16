<script setup lang="ts">
import CombatMapInsets from "./components/tables/CombatMapInsets.vue"
import DivisionStaff from "./components/staff/DivisionStaff.vue"
import TradingCard from "./components/cards/TradingCard.vue"
</script>

<template>
  <main>
    <CombatMapInsets />
    <div>
      <!-- TODO: `defineProps({})` method in: "DivisionStaff" -->
      <DivisionStaff v-for="members in post" :key="members.divisionCommander.uuid">
        <!--
          TODO: `defineProps({})` method in: "TradingCard" must be in v-bind-
          -to be passed as dynamic value(s) 

          a-la: ...
         -->
          <TradingCard title="I-400-class" description="Imperial Japanese Navy unique, and novel - special operations Submarine" vessel="Submarine Carrier" />
        <span>{{ members }}</span>
      </DivisionStaff>
    </div>
  </main>
</template>

<style scoped lang="scss"></style>

